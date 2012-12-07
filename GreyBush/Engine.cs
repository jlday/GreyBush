using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace GreyBush
{
    /// <summary>
    /// Main fuzzing engine.  Creates the mutation and debugger objects and holds everything together while the target is fuzzed.
    /// </summary>
	class Engine
	{
		#region Private_Members

		private EngineSettings settings;
		private Debugger debugger;
		private Fuzzer fuzzer;
		private double progress = 0.0;
		private DateTime startTime;

		#endregion Private_Members

		#region Public_Functions

		/// <summary>
		/// Called to update the progress bar of the GUI.
		/// Additionally, performs checks to confirm the worker thread hosting the engine has not been canceled.
		/// </summary>
		public double Progress
		{
			get
			{
				return this.progress;
			}
			set
			{
				this.progress = value;
				this.settings.worker.ReportProgress((int)this.progress);
				this.CheckCancel();
			}
		}

		/// <summary>
		/// Constructor.  Initializes the settings of the Engine.
		/// </summary>
		/// <param name="s"></param>
		public Engine(EngineSettings s)
		{
			s.CheckSettingsValidity();
			this.settings = s;
			this.debugger = new Debugger(new DebuggerSettings(this.settings));
		}

		/// <summary>
		/// Starts the engine.  Called by the worker thread in the GUI.
		/// </summary>
		public void Go()
		{
			this.startTime = DateTime.Now;

			this.fuzzer = FuzzerType.GetObject(this.settings.Type, this.settings);
			this.UpdateSummary();
			this.Progress += this.fuzzer.ProgressIncrement;

			if (this.fuzzer is FileFormatFuzzer)  // Kills process upon unsuccessful test
			{
				while (fuzzer.FuzzedCount <= fuzzer.TotalRuns)
				{
                    this.debugger.ClearDebugMessages();
					string testFile = this.fuzzer.Next();
					this.debugger.StartProcess(this.settings.Debuggee, testFile);

					this.Wait();

					this.debugger.KillProcess();
					
					if (this.debugger.DebugMessages.Length > 0)
					{
						this.RecordCrash(testFile);
						this.fuzzer.wasSuccess(true);
					}
					else
					{
						File.Delete(testFile);
						this.fuzzer.wasSuccess(false);
					}

					this.UpdateSummary();
					this.Progress += this.fuzzer.ProgressIncrement;
				}
			}
			else if (this.fuzzer is NetworkFuzzer) // Leaves process running after each test
			{
				while (this.fuzzer.FuzzedCount < this.fuzzer.TotalRuns)
				{
					this.debugger.ClearDebugMessages();
					
					if (!this.debugger.IsRunning)
					{
						this.debugger.StartProcess(this.settings.Debuggee);
					}

					string testRun = this.fuzzer.Next();

					this.Wait();

					if (this.debugger.DebugMessages.Length > 0)
					{
						this.RecordCrash(testRun);
						this.fuzzer.wasSuccess(true);
					}
					else
					{
						this.fuzzer.wasSuccess(false);
					}

					this.UpdateSummary();
					this.Progress += this.fuzzer.ProgressIncrement;
				}
			}
		}

		#endregion Public_Functions

		#region Private_Functions

		/// <summary>
		/// Checks if the worker thread running the main instance of the Engine has been ordered to cancel.
		/// If so, this function raises an exception that is caught in the GUI, terminating the Engine's session.
		/// </summary>
		private void CheckCancel()
		{
			if (this.settings.worker.CancellationPending)
			{
				this.debugger.KillProcess();
				throw new Exception("No Problem, just exiting");
			}
		}

		/// <summary>
		/// Pauses thread while debugger works.  Time paused specified in the settings.
        /// 
        /// Messy, could be cleaned up quite a bit.
		/// </summary>
		private void Wait()
		{
			DateTime startFile = DateTime.Now;

			if (this.settings.MonitorProcessThreshold) // wait while the process cpu usage is above threshold percent
			{
				if (this.debugger.GetCurrentProcessUse <= this.settings.ProcessorThreshold) // Make sure the threshold is reached before starting
					Thread.Sleep(100);

				int elapsed = 0;

                while ((this.debugger.GetCurrentProcessUse > this.settings.ProcessorThreshold) && (elapsed < this.settings.EventTimeout && this.settings.EnableEventTimeout) && ((DateTime.Now - startFile).Seconds < this.settings.GeneralTimeout && this.settings.EnableGeneralTimeout))
				{
					elapsed = DateTime.Now.Millisecond;
					if (elapsed < this.debugger.LastEvent)
						elapsed += 1000;
					elapsed -= this.debugger.LastEvent;
				}
			}
			else if (this.settings.EnableEventTimeout && this.settings.EnableGeneralTimeout)
			{
				int elapsed = 0;

				while (elapsed < this.settings.EventTimeout && (DateTime.Now - startFile).Seconds < this.settings.GeneralTimeout)
				{
					if ((this.settings.GeneralTimeout * 1000) - (DateTime.Now - startFile).Milliseconds > this.settings.EventTimeout - elapsed)
						Thread.Sleep(this.settings.EventTimeout - elapsed);
					else
						Thread.Sleep((this.settings.GeneralTimeout * 1000) - (DateTime.Now - startFile).Milliseconds);

					elapsed = DateTime.Now.Millisecond;
					if (elapsed < this.debugger.LastEvent)
						elapsed += 1000;
					elapsed -= this.debugger.LastEvent;
				}
			}
			else if (this.settings.EnableEventTimeout)
			{
				Thread.Sleep(this.settings.GeneralTimeout * 1000);
			}
			else if (this.settings.EnableGeneralTimeout)
			{
				int elapsed = 0;

				while (elapsed < this.settings.EventTimeout)
				{
					Thread.Sleep(this.settings.EventTimeout - elapsed);
					elapsed = DateTime.Now.Millisecond;
					if (elapsed < this.debugger.LastEvent)
						elapsed += 1000;
					elapsed -= this.debugger.LastEvent;
				}

			}
			else
			{
				if (!this.debugger.IsRunning)
					Thread.Sleep(500);
				while (this.debugger.IsRunning) 
                    Thread.Sleep(500);
			}
		}

		/// <summary>
		/// Dumps the output from the debugger into a file named after the crash file with '.txt' appended to it
		/// Only called in the event that a crash is found in the target application.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="Message"></param>
		private void RecordCrash(string path)
		{
			this.settings.Details = "**************************************************************\r\n";
			this.settings.Details += this.debugger.DebugMessages;
			this.settings.Details += "\r\n**************************************************************\r\n";

			FileStream details = File.Create(path + ".txt");

			details.Write(System.Text.Encoding.ASCII.GetBytes(this.settings.Details + this.fuzzer.LastTransformations()), 0, System.Text.Encoding.ASCII.GetByteCount(this.settings.Details + this.fuzzer.LastTransformations()));
			details.Close();
		}

		/// <summary>
		/// Updates the summary variable in the settings object.  This data is pulled by the GUI in order to update the Summary text box while the engine is running.
		/// </summary>
		private void UpdateSummary()
		{
			TimeSpan elapsed = (DateTime.Now - this.startTime);
			TimeSpan remaining = TimeSpan.FromTicks(elapsed.Ticks / ((this.fuzzer.FuzzedCount > 0)? this.fuzzer.FuzzedCount : 1) * (this.fuzzer.TotalRuns - this.fuzzer.FuzzedCount));
			
			this.settings.Summary = Enum.GetName(typeof(FuzzerType.Type), this.settings.Type) + "\r\n\r\n";
			this.settings.Summary += "*********************************************\r\n\r\n";
			this.settings.Summary += this.fuzzer.Description() + "\r\n";
			this.settings.Summary += "*********************************************\r\n\r\n";
			this.settings.Summary += this.fuzzer.Settings() + "\r\n\r\n";
			this.settings.Summary += "*********************************************\r\n\r\n";
			this.settings.Summary += "Total Attempts to be made: " + this.fuzzer.TotalRuns.ToString() + "\r\n";
			this.settings.Summary += "Total Attempts Tried: " + this.fuzzer.FuzzedCount.ToString() + "\r\n";
			this.settings.Summary += "Attempts Remaining: " + (this.fuzzer.TotalRuns - this.fuzzer.FuzzedCount).ToString() + "\r\n";
			this.settings.Summary += "Total Successful Runs: " + this.fuzzer.SuccessfulRunCount.ToString() + "\r\n";
			this.settings.Summary += "Success Rate: " + ((double)this.fuzzer.SuccessfulRunCount / (double)((this.fuzzer.FuzzedCount != 0)? this.fuzzer.FuzzedCount : 1) * 100.0).ToString() + "%\r\n";
			this.settings.Summary += "Percentage Complete: " + ((double)this.fuzzer.FuzzedCount / (double)this.fuzzer.TotalRuns * 100.0).ToString() + "%\r\n";
			this.settings.Summary += "Elapsed Time [DD:HH:MM]: " + elapsed.Days.ToString().PadLeft(2, '0') + ":" + elapsed.Hours.ToString().PadLeft(2, '0') + ":" + elapsed.Minutes.ToString().PadLeft(2, '0') + "\r\n";
			this.settings.Summary += "Estimated Time Remaining [DD:HH:MM]: " + remaining.Days.ToString().PadLeft(2, '0') + ":" + remaining.Hours.ToString().PadLeft(2, '0') + ":" + remaining.Minutes.ToString().PadLeft(2, '0') + "\r\n";
		}

		#endregion Private_Functions
	}
}

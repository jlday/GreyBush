using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace GreyBush
{
	public partial class Form1 : Form
	{
		private BackgroundWorker worker = null;
		private EngineSettings settings = new EngineSettings();
		private List<string> IgnoredExceptions = new List<string>();
		private List<string> RecordedExceptions = new List<string>();

		public Form1()
		{
			InitializeComponent();

			this.TargetTextBox.Text = this.settings.Debuggee;
			this.CrashDirectoryTextBox.Text = this.settings.CrashDirectory;
			this.BaseFileTextBox.Text = this.settings.BaseFile;
			this.CommandLineArgsTextBox.Text = this.settings.CLI;
			this.HideWindowCheckBox.Checked = this.settings.HideMainWindow;
			this.AutoCloseCheckBox.Checked = this.settings.AutoCloseSpawnedWindows;
			this.OKbeforeCloseCheckBox.Checked = this.settings.OKbeforeCLOSE;
			this.AlwaysClickButtonsCheckBox.Checked = this.settings.AlwaysClick;
			this.OnlyCloseWithClickCheckbox.Checked = this.settings.OnlyCloseIfButtonClicked;

			System.Type mode = FuzzerType.GetType(this.settings.Type);
			this.FileFormatRadio.Checked = mode.IsSubclassOf(typeof(FileFormatFuzzer));
			this.NetworkFuzzerRadio.Checked = mode.IsSubclassOf(typeof(NetworkFuzzer));

			this.SequentialFuzzerRadio.Checked = mode == typeof(SequentialFuzzer);
			this.RandomFuzzRadio.Checked = mode == typeof(RandomFuzz);
			this.PcapRandomFuzzRadio.Checked = mode == typeof(PcapRandomFuzz);

			this.EventTimeoutCheckbox.Checked = this.settings.EnableEventTimeout;
			this.TimeoutEnabledCheckbox.Checked = this.settings.EnableGeneralTimeout;

			this.EventTimeoutTextbox.Text = this.settings.EventTimeout.ToString();
			this.GeneralTimeoutTextbox.Text = this.settings.GeneralTimeout.ToString();

			// RandomFuzz Settings
			this.RandomFuzzSprayTextBox.Text = this.settings.RandomFuzzSprayPercentage.ToString();
			this.RandomFuzzTotalAttemptsTextBox.Text = this.settings.RandomFuzzTotalAttempts.ToString();
			this.RandomFuzzModificationOptionsCheckList.Items.AddRange(Enum.GetNames(typeof(Fuzzer.Modification)));
			foreach (Fuzzer.Modification m in this.settings.RandomFuzzModifications)
			{
				if(this.RandomFuzzModificationOptionsCheckList.Items.Contains(Enum.GetName(typeof(Fuzzer.Modification), m)))
				{
					int index = this.RandomFuzzModificationOptionsCheckList.Items.IndexOf(Enum.GetName(typeof(Fuzzer.Modification), m));
					this.RandomFuzzModificationOptionsCheckList.SetItemChecked(index, true);
				}
			}
			this.RandomFuzzPermutationBytes.Items.AddRange(Enum.GetNames(typeof(Fuzzer.ModificationByte)));
			foreach (uint b in this.settings.RandomFuzzModificationBytes)
			{
				if(this.RandomFuzzPermutationBytes.Items.Contains(Enum.GetName(typeof(Fuzzer.ModificationByte), b)))
				{
					int index = this.RandomFuzzPermutationBytes.Items.IndexOf(Enum.GetName(typeof(Fuzzer.ModificationByte), b));
					this.RandomFuzzPermutationBytes.SetItemChecked(index, true);
				}
			}
			this.RandomFuzzEndFilePercentageTextBox.Text = this.settings.RandomFuzzEndFilePercentage.ToString(); 
			this.RandomFuzzStartFilePercentageTextBox.Text = this.settings.RandomFuzzStartFilePercentage.ToString();

			// Sequential Settings
			this.SequentialFuzzStartingOffset.Text = this.settings.SequentialFuzzStartingIndex.ToString();
			this.SequentialFuzzEndingOffset.Text = this.settings.SequentialFuzzEndingIndex.ToString();
			
			this.SequentialFuzModificationBytes.Items.AddRange(Enum.GetNames(typeof(Fuzzer.ModificationByte)));
			foreach (Fuzzer.ModificationByte b in this.settings.SequentialFuzzerModificationBytes)
				this.SequentialFuzModificationBytes.SetItemChecked(this.SequentialFuzModificationBytes.Items.IndexOf(Enum.GetName(typeof(Fuzzer.ModificationByte), b)), true);
			
			this.SequentialFuzzModificationOptions.Items.AddRange(Enum.GetNames(typeof(Fuzzer.Modification)));
			foreach(Fuzzer.Modification m in this.settings.SequentialFuzzerModifications)
				this.SequentialFuzzModificationOptions.SetItemChecked(this.SequentialFuzzModificationOptions.Items.IndexOf(Enum.GetName(typeof(Fuzzer.Modification), m)), true);
			
			this.SequentialFuzzModificationIncrement.Items.AddRange(Enum.GetNames(typeof(Fuzzer.ModificationByteSize)));
			foreach (Fuzzer.ModificationByteSize s in this.settings.SequentialFuzzerModificationIncrements)
				this.SequentialFuzzModificationIncrement.SetItemChecked(this.SequentialFuzzModificationIncrement.Items.IndexOf(Enum.GetName(typeof(Fuzzer.ModificationByteSize), s)), true);
			
			this.SequentialFuzzModificationSize.Items.AddRange(Enum.GetNames(typeof(Fuzzer.ModificationByteSize)));
			foreach (Fuzzer.ModificationByteSize s in this.settings.SequentialFuzzerModificationSizes)
				this.SequentialFuzzModificationSize.SetItemChecked(this.SequentialFuzzModificationSize.Items.IndexOf(Enum.GetName(typeof(Fuzzer.ModificationByteSize), s)), true);

			// Debugger Settings
			this.IgnoredExceptions.AddRange(Enum.GetNames(typeof(ErrorCode)));
			foreach (ErrorCode e in this.settings.ErrorCodes)
			{
				this.IgnoredExceptions.Remove(Enum.GetName(typeof(ErrorCode), e));
				this.RecordedExceptions.Add(Enum.GetName(typeof(ErrorCode), e));
			}

			this.IgnoredListBox.Items.AddRange(this.IgnoredExceptions.ToArray());
			this.RecordedExceptoinsListBox.Items.AddRange(this.RecordedExceptions.ToArray());
			this.HideDebuggerCheckBox.Checked = this.settings.HideDebugger;
			this.WaitForFullStartupCheckbox.Checked = this.settings.WaitForFullStartup;
			this.ProcessThresholdCheckbox.Checked = this.settings.MonitorProcessThreshold;
			this.ProcessThresholdTextBox.Text = this.settings.ProcessorThreshold.ToString();

			this.KillAlsoCheckBox.Checked = this.settings.EnableKillAlso;
			this.KillAlsoTextBox.Text = this.settings.KillAlso;

			this.IgnoreExceptionsCheckbox.Checked = this.settings.IgnoreExceptions;
		}

		private void UpdateSettings()
		{
			this.settings.worker = this.worker;

			this.settings.Details = "";
			this.settings.Summary = "";

			this.settings.Debuggee = this.TargetTextBox.Text;
			this.settings.CrashDirectory = this.CrashDirectoryTextBox.Text;
			this.settings.BaseFile = this.BaseFileTextBox.Text;
			this.settings.CLI = this.CommandLineArgsTextBox.Text;
			this.settings.HideMainWindow = this.HideWindowCheckBox.Checked;
			this.settings.AutoCloseSpawnedWindows = this.AutoCloseCheckBox.Checked;
			this.settings.OKbeforeCLOSE = this.OKbeforeCloseCheckBox.Checked;
			this.settings.AlwaysClick = this.AlwaysClickButtonsCheckBox.Checked;
			this.settings.OnlyCloseIfButtonClicked = this.OnlyCloseWithClickCheckbox.Checked;

			if (this.RandomFuzzRadio.Checked && this.FileFormatRadio.Checked)
				this.settings.Type = FuzzerType.Type.RandomFuzz;
			else if (this.SequentialFuzzerRadio.Checked && this.FileFormatRadio.Checked)
				this.settings.Type = FuzzerType.Type.Sequential;
			else if (this.PcapRandomFuzzRadio.Checked && this.NetworkFuzzerRadio.Checked)
				this.settings.Type = FuzzerType.Type.PcapRandomFuzz;

			this.settings.EnableEventTimeout = this.EventTimeoutCheckbox.Checked;
			this.settings.EnableGeneralTimeout = this.TimeoutEnabledCheckbox.Checked;

			this.settings.GeneralTimeout = int.Parse(this.GeneralTimeoutTextbox.Text);
			this.settings.EventTimeout = int.Parse(this.EventTimeoutTextbox.Text);

			// RandomFuzz Settings
			this.settings.RandomFuzzSprayPercentage = double.Parse(this.RandomFuzzSprayTextBox.Text);
			this.settings.RandomFuzzTotalAttempts = uint.Parse(this.RandomFuzzTotalAttemptsTextBox.Text);
			this.settings.RandomFuzzModifications.Clear();
			foreach (string item in this.RandomFuzzModificationOptionsCheckList.CheckedItems)
			{
				this.settings.RandomFuzzModifications.Add((Fuzzer.Modification)Enum.Parse(typeof(Fuzzer.Modification), item));
			}
			this.settings.RandomFuzzModificationBytes.Clear();
			foreach (string item in this.RandomFuzzPermutationBytes.CheckedItems)
			{
				this.settings.RandomFuzzModificationBytes.Add((Fuzzer.ModificationByte)Enum.Parse(typeof(Fuzzer.ModificationByte), item));
			}
			this.settings.RandomFuzzStartFilePercentage = double.Parse(this.RandomFuzzStartFilePercentageTextBox.Text);
			this.settings.RandomFuzzEndFilePercentage = double.Parse(this.RandomFuzzEndFilePercentageTextBox.Text);

			// Sequential Settings
			this.settings.SequentialFuzzStartingIndex = double.Parse(this.SequentialFuzzStartingOffset.Text);
			this.settings.SequentialFuzzEndingIndex = double.Parse(this.SequentialFuzzEndingOffset.Text);
			this.settings.SequentialFuzzerModificationBytes.Clear();
			foreach (string item in this.SequentialFuzModificationBytes.CheckedItems)
				this.settings.SequentialFuzzerModificationBytes.Add((Fuzzer.ModificationByte)Enum.Parse(typeof(Fuzzer.ModificationByte), item));
			this.settings.SequentialFuzzerModificationIncrements.Clear();
			foreach (string item in this.SequentialFuzzModificationIncrement.CheckedItems)
				this.settings.SequentialFuzzerModificationIncrements.Add((Fuzzer.ModificationByteSize)Enum.Parse(typeof(Fuzzer.ModificationByteSize), item));
			this.settings.SequentialFuzzerModificationSizes.Clear();
			foreach (string item in this.SequentialFuzzModificationSize.CheckedItems)
				this.settings.SequentialFuzzerModificationSizes.Add((Fuzzer.ModificationByteSize)Enum.Parse(typeof(Fuzzer.ModificationByteSize), item));
			this.settings.SequentialFuzzerModifications.Clear();
			foreach (string item in this.SequentialFuzzModificationOptions.CheckedItems)
				this.settings.SequentialFuzzerModifications.Add((Fuzzer.Modification)Enum.Parse(typeof(Fuzzer.Modification), item));

			this.settings.ErrorCodes.Clear();
			foreach (string item in this.RecordedExceptions)
			{
				this.settings.ErrorCodes.Add((ErrorCode)Enum.Parse(typeof(ErrorCode), item));
			}

			this.settings.WaitForFullStartup = this.WaitForFullStartupCheckbox.Checked;
			this.settings.MonitorProcessThreshold = this.ProcessThresholdCheckbox.Checked;
			this.settings.ProcessorThreshold = double.Parse(this.ProcessThresholdTextBox.Text);
			this.settings.HideDebugger = this.HideDebuggerCheckBox.Checked;
			this.settings.KillAlso = this.KillAlsoTextBox.Text;
			this.settings.EnableKillAlso = this.KillAlsoCheckBox.Checked;

			this.settings.IgnoreExceptions = this.IgnoreExceptionsCheckbox.Checked;
		}

		private void UpdateExceptionsList()
		{
			this.IgnoredListBox.Items.Clear();
			this.RecordedExceptoinsListBox.Items.Clear();

			foreach (string s in this.RecordedExceptions)
			{
				if (s.ToUpper().Contains(this.FilterErrorCodesTextBox.Text.ToUpper()))
					this.RecordedExceptoinsListBox.Items.Add(s);
			}

			foreach (string s in this.IgnoredExceptions)
			{
				if (s.ToUpper().Contains(this.FilterErrorCodesTextBox.Text.ToUpper()))
					this.IgnoredListBox.Items.Add(s);
			}
		}

		private void TargetBrowseButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog outputDialog = new OpenFileDialog();
			outputDialog.Filter = "Application | *.exe";
			outputDialog.Title = "Target Application";

			if (outputDialog.ShowDialog() != DialogResult.Cancel)
			{
				this.TargetTextBox.Text = outputDialog.FileName;
			}
		}

		private void CrashDirectoryButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog databaseDialog = new FolderBrowserDialog();
			databaseDialog.Description = "Select a folder to use as the directory for the crash files";
			databaseDialog.RootFolder = Environment.SpecialFolder.Desktop;


			if (databaseDialog.ShowDialog() != DialogResult.Cancel)
			{
				this.CrashDirectoryTextBox.Text = databaseDialog.SelectedPath;
			}
		}

		private void BaseFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog outputDialog = new OpenFileDialog();
			outputDialog.Filter = "Any | *.*";
			outputDialog.Title = "Base File";

			if (outputDialog.ShowDialog() != DialogResult.Cancel)
			{
				this.BaseFileTextBox.Text = outputDialog.FileName;
			}
		}

		private void GoButton_Click(object sender, EventArgs e)
		{
			if (this.worker != null && this.worker.IsBusy)
				return;

			this.worker = new BackgroundWorker();

			this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);

			this.worker.WorkerSupportsCancellation = true;
			this.worker.WorkerReportsProgress = true;

			this.worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
			this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

			this.UpdateSettings();

			try
			{
				this.worker.RunWorkerAsync();
			}
			catch (Exception exception)
			{
				if (exception.Message != "No problem, just exiting")
				{
					MessageBox.Show("Error: " + exception.Message);
				}
			}
		}

		#region Background_Worker

		private void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			Engine engine = new Engine(this.settings);

			engine.Go();
		}

		private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar1.Value = e.ProgressPercentage;
			this.DetailsBox.Text = this.settings.Details;
			this.SummaryBox.Text = this.settings.Summary;
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.progressBar1.Value = 100;
			MessageBox.Show("Done!");
			this.progressBar1.Value = 0;
		}

		#endregion Background_Worker

		private void StopButton_Click(object sender, EventArgs e)
		{
			if (this.worker != null && this.worker.IsBusy && this.worker.WorkerSupportsCancellation)
			{
				this.worker.CancelAsync();
			}
		}

		private void SequentialFuzzerRadio_CheckedChanged(object sender, EventArgs e)
		{
			this.FileFormatTabControl.SelectedTab = this.SequentialTab;
			this.SequentialOptionsGroupBox.Enabled = this.SequentialFuzzerRadio.Checked;
		}

		private void RandomFuzzRadio_CheckedChanged(object sender, EventArgs e)
		{
			this.FileFormatTabControl.SelectedTab = this.RandomFuzzTab;
			this.RandomFuzzOptionsGroupBox.Enabled = this.RandomFuzzRadio.Checked;
		}

		private void TimeoutEnabledCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			this.GeneralTimeoutTextbox.Enabled = this.TimeoutEnabledCheckbox.Checked;
		}

		private void EventTimeoutCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			this.EventTimeoutTextbox.Enabled = this.EventTimeoutCheckbox.Checked;
		}

		private void FilterErrorCodesTextBox_TextChanged(object sender, EventArgs e)
		{
			this.UpdateExceptionsList();
		}

		private void SingleToRecordButton_Click(object sender, EventArgs e)
		{
			if (this.IgnoredListBox.Items.Count == 0)
				return;

			if (this.IgnoredListBox.SelectedItems.Count == 0)
				this.IgnoredListBox.SelectedItem = this.IgnoredListBox.Items[0];
			
			string item = this.IgnoredListBox.Text;

			this.IgnoredExceptions.Remove(item);
			this.RecordedExceptions.Add(item);

			this.UpdateExceptionsList();
		}

		private void SingleToIgnoreButton_Click(object sender, EventArgs e)
		{
			if (this.RecordedExceptoinsListBox.Items.Count == 0)
				return;

			if (this.RecordedExceptoinsListBox.SelectedItems.Count == 0)
				this.RecordedExceptoinsListBox.SelectedItem = this.RecordedExceptoinsListBox.Items[0];

			string item = this.RecordedExceptoinsListBox.Text;

			this.IgnoredExceptions.Add(item);
			this.RecordedExceptions.Remove(item);

			this.UpdateExceptionsList();
		}

		private void MoveAllRecordButton_Click(object sender, EventArgs e)
		{
			foreach (string item in this.IgnoredListBox.Items)
			{
				if (item.ToUpper().Contains(this.FilterErrorCodesTextBox.Text.ToUpper()))
				{
					this.IgnoredExceptions.Remove(item);
					this.RecordedExceptions.Add(item);
				}
			}
			this.UpdateExceptionsList();
		}

		private void MoveAllIgnoreButton_Click(object sender, EventArgs e)
		{
			foreach (string item in this.RecordedExceptoinsListBox.Items)
			{
				if (item.ToUpper().Contains(this.FilterErrorCodesTextBox.Text.ToUpper()))
				{
					this.IgnoredExceptions.Add(item);
					this.RecordedExceptions.Remove(item);
				}
			}
			this.UpdateExceptionsList();
		}

		private void KillAlsoCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.KillAlsoTextBox.Enabled = this.KillAlsoCheckBox.Checked;
		}

		private void NetworkFuzzerRadio_CheckedChanged(object sender, EventArgs e)
		{
			this.FuzzerTabControl.SelectedTab = this.NetworkFuzzerTab;
		}

		private void FileFormatRadio_CheckedChanged(object sender, EventArgs e)
		{
			this.FuzzerTabControl.SelectedTab = this.FileFormatTab;
		}

		private void SequentialFuzzModificationOptions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Unchecked && this.SequentialFuzzModificationOptions.CheckedItems.Count < 1)
				this.SequentialFuzzModificationOptions.SetItemChecked(e.Index, true);
		}

		private void SequentialFuzModificationBytes_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Unchecked && this.SequentialFuzModificationBytes.CheckedItems.Count < 1)
				this.SequentialFuzModificationBytes.SetItemChecked(e.Index, true);
		}

		private void SequentialFuzzModificationIncrement_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Unchecked && this.SequentialFuzzModificationIncrement.CheckedItems.Count < 1)
				this.SequentialFuzzModificationIncrement.SetItemChecked(e.Index, true);
		}

		private void SequentialFuzzModificationSize_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Unchecked && this.SequentialFuzzModificationSize.CheckedItems.Count < 1)
				this.SequentialFuzzModificationSize.SetItemChecked(e.Index, true);
		}

		private void AutoCloseCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.OKbeforeCloseCheckBox.Enabled = this.AutoCloseCheckBox.Checked;
			this.AlwaysClickButtonsCheckBox.Enabled = (this.OKbeforeCloseCheckBox.Checked && this.OKbeforeCloseCheckBox.Enabled);
			this.OnlyCloseWithClickCheckbox.Enabled = (this.OKbeforeCloseCheckBox.Checked && this.OKbeforeCloseCheckBox.Enabled);
		}

		private void PcapRandomFuzzRadio_CheckedChanged(object sender, EventArgs e)
		{
			this.NetworkFuzzerTabControl.SelectedTab = this.PcapRandomFuzzTab;
			this.PcapRandomFuzzGroupBox.Enabled = this.PcapRandomFuzzRadio.Checked;
		}

		private void OKbeforeCloseCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.AlwaysClickButtonsCheckBox.Enabled = (this.OKbeforeCloseCheckBox.Checked && this.OKbeforeCloseCheckBox.Enabled);
			this.OnlyCloseWithClickCheckbox.Enabled = (this.OKbeforeCloseCheckBox.Checked && this.OKbeforeCloseCheckBox.Enabled);
		}

		private void ProcessThresholdCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.WaitForFullStartupCheckbox.Checked && this.ProcessThresholdCheckbox.Checked)
				this.WaitForFullStartupCheckbox.Checked = true;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace GreyBush
{
    /// <summary>
    /// Settings object to track all settings that are used by each component of the fuzzer.
    /// 
    /// This object is used to initialize both the default values of the GUI and any other 
    /// Settings objects (such as the DebuggerSettings object).  All changes to default values 
    /// should be done here.
    /// </summary>
	public class EngineSettings
	{
		#region Public_Members

		// Status Return
		public string Summary;
		public string Details;
		public BackgroundWorker worker;

		// Base File Options
		public string Debuggee = "";
		public string CLI = "";
        public string BaseFile = ""; 
		public string CrashDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Crashes\\";
		public bool HideMainWindow = true;
		public bool AutoCloseSpawnedWindows = true;
		public bool OKbeforeCLOSE = true;
		public bool OnlyCloseIfButtonClicked = true;
		public bool AlwaysClick = false;

		// Debugger Options
		public bool EnableEventTimeout = false;
		public int EventTimeout = 750;
		public bool EnableGeneralTimeout = true;
		public int GeneralTimeout = 20;
		public bool EnableKillAlso = false;
		public string KillAlso = "ctfmon.exe";
		public bool WaitForFullStartup = true;
		public bool MonitorProcessThreshold = true;
		public double ProcessorThreshold = 1;
		public bool HideDebugger = true;
		public bool IgnoreExceptions = true;
		public List<ErrorCode> ErrorCodes = new List<ErrorCode>{ ErrorCode.STATUS_ACCESS_VIOLATION };

		// Fuzzer Options
		public FuzzerType.Type Type = FuzzerType.Type.RandomFuzz;

		// RandomFuzz
		public double RandomFuzzSprayPercentage = 1.5;
		public uint RandomFuzzTotalAttempts = 75000;
		public double RandomFuzzStartFilePercentage = 15.0;
		public double RandomFuzzEndFilePercentage = 85.0;
		public List<Fuzzer.ModificationByte> RandomFuzzModificationBytes = Enum.GetValues(typeof(Fuzzer.ModificationByte)).OfType<Fuzzer.ModificationByte>().ToList();
		public List<Fuzzer.Modification> RandomFuzzModifications = Enum.GetValues(typeof(Fuzzer.Modification)).OfType<Fuzzer.Modification>().ToList();

		// Sequential Fuzzer
		public double SequentialFuzzStartingIndex = 0;
		public double SequentialFuzzEndingIndex = 0;
		public List<Fuzzer.ModificationByte> SequentialFuzzerModificationBytes = new List<Fuzzer.ModificationByte> { Fuzzer.ModificationByte.OxFF };
		public List<Fuzzer.Modification> SequentialFuzzerModifications = new List<Fuzzer.Modification> { Fuzzer.Modification.Xor };
		public List<Fuzzer.ModificationByteSize> SequentialFuzzerModificationSizes = new List<Fuzzer.ModificationByteSize> { Fuzzer.ModificationByteSize.OxOO4 };
		public List<Fuzzer.ModificationByteSize> SequentialFuzzerModificationIncrements = new List<Fuzzer.ModificationByteSize> { Fuzzer.ModificationByteSize.OxOO4 };

		#endregion Public_Members

		/// <summary>
		/// Checks to make sure all settings are valid, throws exceptions otherwise.
		/// Called before the Engine does any processing.
		/// </summary>
		public void CheckSettingsValidity()
		{
		    if(!File.Exists(this.Debuggee))
				throw new Exception("Debuggee Not Found");

			if (!File.Exists(this.BaseFile))
				throw new Exception("Base File Not Found");

			if (!Directory.Exists(this.CrashDirectory))
				Directory.CreateDirectory(this.CrashDirectory);

			if (!FuzzerType.Values().Contains(this.Type))
				throw new Exception("Invalid Fuzzer Type");

			if (this.GeneralTimeout > 60)
				this.GeneralTimeout = 60;
			if (this.GeneralTimeout < 0)
				this.GeneralTimeout = int.MaxValue;

			if (this.EventTimeout > 1000)
				this.EventTimeout = 1000;
			if (this.EventTimeout < 0)
				this.EventTimeout = int.MaxValue;

			if (this.KillAlso.Contains('.'))
			{
				this.KillAlso = this.KillAlso.Substring(0, this.KillAlso.LastIndexOf('.'));
			}
		}
	}
}

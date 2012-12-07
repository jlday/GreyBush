using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GreyBush
{
    /// <summary>
    /// Basic fuzzer following Charlie Miller's spray style algorithm.
	///	This implementation randomly picks a "Spray Percentage" of bytes from the base file.
	///	It then randomly selects from the available modification operations and applies the modification to the base file.
    ///	
	///	Each iteration is completely random with no dependence on the previous file generated.
    /// </summary>
	class RandomFuzz : FileFormatFuzzer
	{
		#region Private_Members

		private double SprayPercentage = 0; 
		private double startPercentage = 0; 
		private double endPercentage = 0;
		private int sprayCount = 0;
		private int upperBound = 0;
		private int lowerBound = 0;
		private Random random = new Random(DateTime.Now.Millisecond + DateTime.Now.Minute + DateTime.Now.Second * 1024);
		private List<Fuzzer.ModificationByte> ModificationBytes = new List<Fuzzer.ModificationByte>();
		private List<Fuzzer.Modification> Modifications = new List<Fuzzer.Modification>();

		#endregion Private_Members

		#region Public_Functions

		/// <summary>
		/// Standard constructor, initializes the fuzzer given the engine's settings
		/// </summary>
		/// <param name="s"></param>
		public RandomFuzz(EngineSettings s) : base(s) 
		{
			this.Modifications = s.RandomFuzzModifications;
			this.ModificationBytes = s.RandomFuzzModificationBytes;

			this.endPercentage = s.RandomFuzzEndFilePercentage;
			this.startPercentage = s.RandomFuzzStartFilePercentage;

			this.Total = s.RandomFuzzTotalAttempts;
			this.progressIncrement = 100.0 / (this.Total + 1);
			this.SprayPercentage = s.RandomFuzzSprayPercentage;

			this.lowerBound = (int)(this.startPercentage / 100.0 * this.BaseFileStream.Length);
			this.upperBound = (int)(this.endPercentage / 100.0 * this.BaseFileStream.Length);

			this.sprayCount = (int)((double)(this.upperBound - this.lowerBound) * (this.SprayPercentage / 100.0));
		}

		/// <summary>
		/// Generates a new test file to be used as input for the target application, returns the path to the generated file.
		/// </summary>
		/// <returns></returns>
		public override string Next()
		{
			this.Changes.Clear();
			string testFile = this.GetFileName();

			FileStream fuzzedFile = new FileStream(testFile, FileMode.Create, FileAccess.Write);
			this.BaseFileStream.Position = 0;
			this.BaseFileStream.CopyTo(fuzzedFile);
			fuzzedFile.Flush();

            // sprayCount is calculated in the constructor based on the size of the file and the percentage to spray
			for (int count = 0; count < this.sprayCount; ++count)
			{
				Change change = new Change(); // Defined in the FileFormatFuzzer parent class

				change.Offset = this.random.Next(this.lowerBound, this.upperBound);
				this.BaseFileStream.Position = change.Offset;

				change.CurrentValue = new byte[] { (byte)this.BaseFileStream.ReadByte() };
				change.FuzzModificationOperation = this.Modifications[random.Next(0, this.Modifications.Count - 1)];
				change.FuzzModificationByte = this.ModificationBytes[random.Next(0, this.ModificationBytes.Count -1)];
				change.NewValue = this.Modify(change.CurrentValue, new byte[] { (byte)change.FuzzModificationByte }, this.GetOperation(change.FuzzModificationOperation));
				
				fuzzedFile.Position = change.Offset;
				fuzzedFile.Write(change.NewValue, 0, change.NewValue.Length);

                this.Changes.Add(change); // Track each change to report in log file upon successful test case
			}

            fuzzedFile.Flush();
			fuzzedFile.Close();

			return testFile;
		}

		/// <summary>
		/// Gets the string representation of the fuzzer's settings, for use in the GUI
		/// </summary>
		/// <returns></returns>
		public override string Settings()
		{
			string returnValue = "Base File = " + this.BaseFilePath.Substring(this.BaseFilePath.LastIndexOf('\\') + 1) + "\r\n";
			returnValue += "Output Directory = " + this.OutputPath + "\r\n";
			returnValue += "Spray Percentage = " + this.SprayPercentage + "%\r\n";
			returnValue += "Spray File Between: " + this.startPercentage.ToString() + "% and " + this.endPercentage.ToString() + "%\r\n";
			returnValue += "Modifications = ";
			foreach (Modification m in this.Modifications)
			{
				returnValue += Enum.GetName(typeof(Fuzzer.Modification), m) + ", ";
			}
			returnValue = returnValue.Substring(0, returnValue.LastIndexOf(','));
			returnValue += "\r\n";

			returnValue += "Modification Bytes = ";
			foreach (byte b in this.ModificationBytes)
			{
				returnValue += "0x" + b.ToString("X").PadLeft(2, '0') + ", ";
			}
			returnValue = returnValue.Substring(0, returnValue.LastIndexOf(','));
			returnValue += "\r\n";

			return returnValue;
		}

		/// <summary>
		/// Gets the description of the fuzzer for use in the GUI
		/// </summary>
		/// <returns></returns>
		public override string Description()
		{
			string returnValue = "Basic fuzzer following Charlie Miller's spray style algorithm.\r\n";
			returnValue += "This implementation randomly picks a \"Spray Percentage\" of bytes from the base file.\r\n";
			returnValue += "It then randomly selects from the available modification operations and applies the modification to the base file.\r\n\r\n";
			returnValue += "Each iteration is completely random with no dependence on the previous file generated.\r\n";

			return returnValue;
		}

		#endregion

		#region Private_Functions
		#endregion
	}
}

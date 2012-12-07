using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GreyBush
{
    /// <summary>
    /// Goes through the file byte by byte and modifies bytes according to the provided settings.
    /// 
    /// Number of bytes to modify at a time, how to modify those bytes, and how many bytes to increment on each iteration
    /// are provided by the settings object.  Very inefficient for real vulnerability discovery.  
    /// </summary>
	class SequentialFuzzer : FileFormatFuzzer
	{
		#region Private_Members

		private int startingByte = 0;
		private int endingByte = 0;
		private int currentPosition = 0;
		private List<Fuzzer.ModificationByteSize> increments = null;
		private int incrementCount = 0;
		private List<Fuzzer.ModificationByteSize> sizes = null;
		private int sizeCount = 0;
		private List<Fuzzer.ModificationByte> modificationValues = new List<ModificationByte>();
		private int modificationValueCount = 0;
		private List<Fuzzer.Modification> modifications = null;
		private int modificationCount = 0;

		#endregion Private_Members

		#region Public_Functions

		/// <summary>
		/// Constructor.  Initializes the settings of the fuzzer.
		/// </summary>
		/// <param name="s"></param>
		public SequentialFuzzer(EngineSettings s) : base(s) 
		{
			this.startingByte = this.currentPosition = (int)((s.SequentialFuzzStartingIndex / 100.0) * (double)this.BaseFileStream.Length);
			this.endingByte = (int)(s.SequentialFuzzEndingIndex / 100.0 * (double)this.BaseFileStream.Length);
			if (this.endingByte == 0)
				this.endingByte = (int)this.BaseFileStream.Length;

			this.increments = s.SequentialFuzzerModificationIncrements;
			this.sizes = s.SequentialFuzzerModificationSizes;
			this.modifications = s.SequentialFuzzerModifications;

			this.modificationValues = s.SequentialFuzzerModificationBytes;

			this.Total = 0;
			foreach (byte increment in this.increments)
				this.Total += (uint)((this.endingByte - this.startingByte) / (long)increment);
			this.Total *= (uint)this.sizes.Count;
			this.Total *= (uint)this.modifications.Count;
			this.Total *= (uint)this.modificationValues.Count;

			this.progressIncrement = 100.0 / (this.Total + 1);
		}

		/// <summary>
		/// Generates a new fuzzed file, returns a string representing the path to the generated file.
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

			Change change = new Change();
			change.CurrentValue = new byte[(int)this.sizes[this.sizeCount]];
			change.FuzzModificationByte = this.modificationValues[this.modificationValueCount];
			change.FuzzModificationOperation = this.modifications[this.modificationCount];
			change.Offset = this.currentPosition;

			this.BaseFileStream.Position = this.currentPosition;
			this.BaseFileStream.Read(change.CurrentValue, 0, change.CurrentValue.Length);
			byte[] temp = new byte[change.CurrentValue.Length];

			for (int index = 0; index < temp.Length; ++index)
				temp[index] = (byte)this.modificationValues[this.modificationValueCount];

			change.NewValue = this.Modify(change.CurrentValue, temp, this.GetOperation(change.FuzzModificationOperation));
			fuzzedFile.Position = this.currentPosition;
			fuzzedFile.Write(change.NewValue, 0, change.NewValue.Length);
			fuzzedFile.Close();
			this.Changes.Add(change);
			this.currentPosition += (int)this.increments[this.incrementCount];

			if (currentPosition > this.endingByte)
			{
				this.currentPosition = this.startingByte;
				if(++this.modificationValueCount >= this.modificationValues.Count)
				{
					this.modificationValueCount = 0;
					if(++this.modificationCount >= this.modifications.Count)
					{
						this.modificationCount = 0;
						if (++this.sizeCount >= this.sizes.Count)
						{
							this.sizeCount = 0;
							if (++this.incrementCount >= this.increments.Count)
								this.incrementCount = 0;
						}
					}
				}
			}

			return testFile;
		}

		/// <summary>
		/// Returns a description of the current fuzzer, for use in the GUI
		/// </summary>
		/// <returns></returns>
		public override string Description()
		{
			string returnValue = "";
			returnValue += "This is a standard, sequential, bit flipping fuzzer.\r\n";
			returnValue += "This fuzzer only fuzzes within the given byte range and is meant for brute forcing differnet values within a given file.";
			returnValue += "The fuzzer modifies bytes according to the given byte size, incrementing through the file according to the increment size.";
			return returnValue;
		}

		/// <summary>
		/// Returns a string representing the settings of the current fuzzer, for use in the GUI
		/// </summary>
		/// <returns></returns>
		public override string Settings()
		{
			string returnValue = "";

			returnValue += "Base File = " + this.BaseFilePath.Substring(this.BaseFilePath.LastIndexOf('\\') + 1) + "\r\n";
			returnValue += "Output Directory = " + this.OutputPath + "\r\n";
			returnValue += "Starting Index = " + this.startingByte + "\r\n";
			returnValue += "Ending Index = " + this.endingByte + "\r\n";
			returnValue += "Modifications = ";
			foreach (Fuzzer.Modification m in this.modifications)
				returnValue += Enum.GetName(typeof(Fuzzer.Modification), m) + ", ";
			returnValue = returnValue.Substring(0, returnValue.Length - 2) + "\r\n";
			
			returnValue += "Modification Values = 0x";
			foreach (int b in this.modificationValues)
			{
				returnValue += b.ToString("X").PadLeft(2, '0') + ", ";
			}
			returnValue = returnValue.Substring(0, returnValue.Length - 2) + "\r\n";

			returnValue += "Sizes = ";
			foreach (int i in this.sizes)
			{
				returnValue += i.ToString("X") + ", ";
			}
			returnValue = returnValue.Substring(0, returnValue.Length - 2) + "\r\n";


			returnValue += "Increments = ";
			foreach (int b in this.increments)
			{
				returnValue += b.ToString("X") + ", ";
			}
			returnValue = returnValue.Substring(0, returnValue.Length - 2) + "\r\n";

			return returnValue;
		}

		#endregion Public_Functions
	}
}

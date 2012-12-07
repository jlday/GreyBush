using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GreyBush
{
    /// <summary>
    /// Base class for file format fuzzing.  Includes mostly a protected "Change" class to track changes made to 
    /// base files during fuzzing.
    /// </summary>
	public abstract class FileFormatFuzzer : Fuzzer
	{
		#region Protected_Members

		protected string BaseFilePath = "";
		protected FileStream BaseFileStream = null;
		protected List<Change> Changes = new List<Change>();

		#endregion Protected_Members

		#region Public_Functions

		/// <summary>
		/// Constructor.  Initializes the fuzzer and opens the base file.
		/// </summary>
		/// <param name="s"></param>
		public FileFormatFuzzer(EngineSettings s) : base(s)
		{
			this.BaseFilePath = s.BaseFile;
			BaseFileStream = File.OpenRead(s.BaseFile);
		}

		/// <summary>
		/// Basic destructor, closes the opened base file.
		/// </summary>
		~FileFormatFuzzer()
		{
			this.BaseFileStream.Close();
		}

		#endregion Public_Functions

		#region Abstract_Functions

		/// <summary>
		/// Gets the last actions the fuzzer took in order to produce the test file.  Used for recording crashes
		/// </summary>
		/// <returns></returns>
		public override string LastTransformations()
		{
			string returnValue = "";

			foreach (Change change in this.Changes)
			{
				returnValue += change.ToString() + "\r\n";
			}

			return returnValue;
		}

		#endregion Abstract_Functions	

		#region Protected_Functions

		/// <summary>
		/// Generates the name of the new fuzzed file by getting the base file name and appending the fuzzed count to the end.
		/// </summary>
		/// <returns></returns>
		protected string GetFileName()
		{
			return this.OutputPath + this.BaseFilePath.Substring(this.BaseFilePath.LastIndexOf('\\') + 1, this.BaseFilePath.LastIndexOf('.') - this.BaseFilePath.LastIndexOf('\\') - 1) + "-0x" + this.fuzzCount.ToString("X").PadLeft(8, '0') + this.BaseFilePath.Substring(this.BaseFilePath.LastIndexOf('.'));
		}

		#endregion Protected_Functions

		#region Protected_Objects

        /// <summary>
        /// Tracks all information about an individual change that is made and allows that change to be convered into a readable string format.
        /// 
        /// Meant to be included in a list of all changes made during any given iteration of the fuzz run.
        /// </summary>
		protected class Change
		{
			public long Offset = 0;
			public byte[] CurrentValue = new byte[0];
			public Modification FuzzModificationOperation = Modification.Add;
			public ModificationByte FuzzModificationByte = ModificationByte.OxOO;
			public byte[] NewValue = new byte[0];

			public override string ToString()
			{
				string returnValue = "Modified value - 0x";
				string temp = "";
				foreach (byte b in this.CurrentValue)
				{
					temp = temp + ((uint)this.FuzzModificationByte).ToString("X").PadLeft(2, '0');
					returnValue += b.ToString("X").PadLeft(2, '0');
				}
				returnValue += " - at offset 0x" + this.Offset.ToString("X") + " by 0x" + temp;
				returnValue += " with modification operation - " + Enum.GetName(typeof(Modification), this.FuzzModificationOperation) + " - to result in: 0x";
				foreach(byte b in this.NewValue)
					returnValue += b.ToString("X").PadLeft(2, '0');
				returnValue += "\r\n";

				return returnValue;
			}
		}

		#endregion Protected_Objects
	}
}

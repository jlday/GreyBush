using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GreyBush
{
    /// <summary>
    /// Base fuzzer object.  Contains functions for performing binary modifications on data as well as templates
    /// for the necessary functions required for all fuzzers to be used by the engine and the GUI
    /// </summary>
	public abstract class Fuzzer
	{
		#region Protected_Members

		protected bool LastRunSuccessStatus = false;
		protected uint fuzzCount = 0;
		protected string OutputPath = "";
		protected double progressIncrement = 0.0;
		protected uint Total = 0;
		protected uint successes = 0;

		#endregion Protected_Members

		#region Public_Functions

		/// <summary>
		/// Constructor.  Initializes the output path for the fuzzer to store successful runs.
		/// </summary>
		/// <param name="s"></param>
		public Fuzzer(EngineSettings s)
		{
			this.OutputPath = s.CrashDirectory;
			if (this.OutputPath.ElementAt(this.OutputPath.Length - 1) != '\\')
				this.OutputPath += '\\';
		}

		/// <summary>
		/// Gets the number of attempts tried
		/// </summary>
		public uint FuzzedCount
		{
			get
			{
				return this.fuzzCount;
			}
		}

		/// <summary>
		/// Informs the fuzzer whether the the last attempt was successful or not
		/// </summary>
		/// <param name="SuccessStatus"></param>
		virtual public void wasSuccess(bool SuccessStatus)
		{
			this.LastRunSuccessStatus = SuccessStatus;
			if (SuccessStatus)
				this.successes++;
			this.fuzzCount++;
		}

		/// <summary>
		/// Gets the completion pertentage increment per fuzz attempt
		/// </summary>
		public double ProgressIncrement
		{
			get
			{
				return this.progressIncrement;
			}
		}

		/// <summary>
		/// Gets the total number of runs that the fuzzer will make before it finishes
		/// </summary>
		public uint TotalRuns
		{
			get
			{
				return this.Total;
			}
		}

		/// <summary>
		/// Gets the total number of successes that the fuzzer has had
		/// </summary>
		public uint SuccessfulRunCount
		{
			get
			{
				return this.successes;
			}
		}

		#endregion Public_Functions

		#region Abstract_Functions

		/// <summary>
		/// Returns a string representing the settings of the current fuzzer, for use in the GUI
		/// </summary>
		/// <returns></returns>
		public abstract string Settings();

		/// <summary>
		/// Returns a description of the current fuzzer, for use in the GUI
		/// </summary>
		/// <returns></returns>
		public abstract string Description();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public abstract string LastTransformations();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public abstract string Next();

		#endregion Abstract_Functions

		#region Protected_Functions

		#region Mutations

        /// <summary>
        /// Modifies the left byte array by the right byte array according to the given modification operation, 
        /// returns the result.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="modificationOperation"></param>
        /// <returns></returns>
		protected byte[] Modify(byte[] left, byte[] right, Operation modificationOperation)
		{
			if (left.Length != right.Length)
				throw new Exception("Error, left and right operands must be the same length");

			byte[] returnValue = new byte[left.Length];

			int carry = 0;
			for (int index = returnValue.Length - 1; index >= 0; --index)
			{
				int result = modificationOperation((int)left[index], (int)right[index]) + carry;
				carry = 0;

				while (result > 255)
				{
					result -= 256;
					++carry;
				}

				while (result < 0)
				{
					result += 256;
					--carry;
				}

				returnValue[index] = (byte)result;
			}

			return returnValue;
		}

		protected delegate int Operation(int left, int right);

        /// <summary>
        /// Add the left and the right values and return the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Add(int left, int right)
		{
			return left + right;
		}

        /// <summary>
        /// Subtract the right from the left value and return the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Subtract(int left, int right)
		{
			return left - right;
		}

        /// <summary>
        /// Multiplies the left and the right values and returns the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Multiply(int left, int right)
		{
			return left * right;
		}

        /// <summary>
        /// Divides the left value by the right value and returns the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Divide(int left, int right)
		{
			if (right == 0)
				return left;
			return left / right;
		}

        /// <summary>
        /// Returns the right value, used as a formality to simulate assignments, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Assign(int left, int right)
		{
			return right;
		}

        /// <summary>
        /// Performs a logical bitwise AND on the left and right values and returns the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int And(int left, int right)
		{
			return left & right;
		}

        /// <summary>
        /// Performs a logical bitwise OR on the left and right values and returns the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Or(int left, int right)
		{
			return left | right;
		}

        /// <summary>
        /// Performs a logical bitwise XOR on the left and right values and returns the result, called as a value for the Operation delegate
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
		protected static int Xor(int left, int right)
		{
			return left ^ right;
		}

		#endregion Mutations

		#endregion Protected_Functions

		#region Public_Enums

		/// <summary>
		/// Used to represent the different modifications
		/// </summary>
		public enum Modification : uint
		{
			Add,
			And,
			Assign,
			Divide,
			Multiply,
			Or,
			Subtract,
			Xor
		}

		/// <summary>
		/// Gets the associated Operation delegate for the given modification enum
		/// </summary>
		/// <param name="modification"></param>
		/// <returns></returns>
		protected Operation GetOperation(Modification modification)
		{
			switch (modification)
			{
				case Modification.Add:
					return Fuzzer.Add;
				case Modification.And:
					return Fuzzer.And;
				case Modification.Assign:
					return Fuzzer.Assign;
				case Modification.Divide:
					return Fuzzer.Divide;
				case Modification.Multiply:
					return Fuzzer.Multiply;
				case Modification.Or:
					return Fuzzer.Or;
				case Modification.Subtract:
					return Fuzzer.Subtract;
				case Modification.Xor:
					return Fuzzer.Xor;
			}

			throw new Exception("Error getting Operation delegate for the given modification operation");
		}

		/// <summary>
		/// The bytes that a fuzzer can modify by.
		/// </summary>
		public enum ModificationByte : uint
		{
			OxOO = 0x00,
			OxO1 = 0x01,
			OxO2 = 0x02,
			OxO3 = 0x03,
			OxO4 = 0x04,
			Ox11 = 0x11,
			Ox22 = 0x22,
			Ox33 = 0x33,
			Ox41 = 0x41,
			Ox42 = 0x42,
			Ox43 = 0x43,
			OxEE = 0xEE,
			OxEF = 0xEF,
			OxFE = 0xFE,
			OxFF = 0xFF
		}

		/// <summary>
		/// The size of the byte to be used for modificaiton and the distance to increment on each iteration.
		/// </summary>
		public enum ModificationByteSize : uint
		{
			OxOO1 = 0x1,
			OxOO2 = 0x2,
			OxOO4 = 0x4,
			OxOO8 = 0x8,
			OxO1O = 0x10,
			OxO2O = 0x20,
			OxO4O = 0x40,
			OxO8O = 0x80,
			Ox1OO = 0x100,
			Ox2OO = 0x200
		}

		#endregion Public_Enums
	}
}

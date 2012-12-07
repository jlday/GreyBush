using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreyBush
{
    /// <summary>
    /// Template for eventually adding a network fuzzer.
    /// 
    /// This fuzzer will take a pcap file of protocol with a specific host and replay that 
    /// protocol to the target host, mutating random bytes according to a spray percentage 
    /// as it goes. 
    /// </summary>
	class PcapRandomFuzz : NetworkFuzzer
	{
		#region Private_Members
		#endregion Private_Members

		#region PublicFunctions

		public PcapRandomFuzz(EngineSettings s) : base(s)
		{
			this.Total = 100000;
		}

		public override string Next()
		{
			return this.OutputPath + "0x" + this.fuzzCount.ToString("X").PadLeft(8, '0') + ".txt";
		}

		public override string Description()
		{
			return "Test Fuzzer... For Now....";
		}

		public override string Settings()
		{
			return "No Settings..";
		}

		public override string LastTransformations()
		{
			return "Nothing happened";
		}

		#endregion PublicFunctions

		#region PrivateFunctions
		#endregion PrivateFunctions
	}
}

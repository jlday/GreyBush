using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreyBush
{
    /// <summary>
    /// Template for eventually adding network fuzzing.
    /// 
    /// Should include some functions for sending and receiving data, possibly include information on how to 
    /// read pcap files in this object to be used for replaying protocols for other derived fuzzers.
    /// </summary>
	public abstract class NetworkFuzzer : Fuzzer
	{
		public NetworkFuzzer(EngineSettings s) : base(s) { }
	}
}

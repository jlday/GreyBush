using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreyBush
{
    /// <summary>
    /// Tracks the different fuzzer mutation algorithms that have been implemented.
    /// 
    /// Contains an enumerated type representing each algorithm, and methods for different operations to 
    /// that can be performed on the enumerated type.
    /// </summary>
	public class FuzzerType
	{
        /// <summary>
        /// Enumerated type to track each mutation algorithm.
        /// </summary>
		public enum Type
		{
			Fuzzer = -1, FileFormatFuzzer = 0, RandomFuzz = 1, Sequential = 2, PcapRandomFuzz
		}

        /// <summary>
        /// Returns a list of all the valid algorithms that can be used for fuzzing.
        /// </summary>
        /// <returns></returns>
		public static List<Type> Values()
		{
			List<Type> returnValue = new List<Type>();

			returnValue.Add(Type.RandomFuzz);
			returnValue.Add(Type.Sequential);
			returnValue.Add(Type.PcapRandomFuzz);

			return returnValue;
		}

        /// <summary>
        /// Returns an initialized fuzzer mutation object.
        /// 
        /// Object is initialized with the provided engine settings object.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="s"></param>
        /// <returns></returns>
		public static Fuzzer GetObject(Type type, EngineSettings s)
		{
			switch (type)
			{
				case Type.Fuzzer:
					throw new Exception("Cannot create a fuzzer of the base class");
				case Type.FileFormatFuzzer:
					throw new Exception("Cannot create a fuzzer of the base class");
				case Type.RandomFuzz:
					return new RandomFuzz(s);
				case Type.Sequential:
					return new SequentialFuzzer(s);
				case Type.PcapRandomFuzz:
					return new PcapRandomFuzz(s);
			}

			throw new Exception("Type doesn't exist");
		}

        /// <summary>
        /// Returns the actual object type corresponding to the enumerated type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
		public static System.Type GetType(Type type)
		{
			switch (type)
			{
				case Type.RandomFuzz:
					return typeof(RandomFuzz);
				case Type.Sequential:
					return typeof(SequentialFuzzer);
				case Type.PcapRandomFuzz:
					return typeof(PcapRandomFuzz);
			}

			return typeof(Fuzzer);
		}
	}
}

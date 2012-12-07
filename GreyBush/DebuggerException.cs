using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreyBush
{
    /// <summary>
    /// Custom exception thrown by the Debugger class.  
    /// </summary>
	class DebuggerException : Exception
	{
		public DebuggerException(string Message) : base(Message) { }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus exception.
    /// </summary>
    public class Exception : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the Exception class.
        /// </summary>
        /// <param name="code">Modbus exception code.</param>
        public Exception(byte code) : base($"Modbus exception code {code} ({CodeToMessage(code)}).") => Code = code;

        /// <summary>
        /// Modbus exception code.
        /// </summary>
        public byte Code { get; set; }

        private static string CodeToMessage(byte code)
        {
            switch (code)
            {
                case 1:
                    return "Illegal Function";
                case 2:
                    return "Illegal Data Address";
                case 3:
                    return "Illegal Data Value";
                case 4:
                    return "Server Device Failure";
                case 5:
                    return "Acknowledge";
                case 6:
                    return "Server Device Busy";
                case 7:
                    return "Negative Acknowledge";
                case 8:
                    return "Memory Parity Error";
                case 10:
                    return "Gateway Path Unavailable";
                case 11:
                    return "Gateway Target Device Failed to Respond";
                default:
                    return "Unknown";
            }
        }
    }
}

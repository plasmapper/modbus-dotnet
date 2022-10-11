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
        public Exception(ExceptionCode code) : base($"Modbus exception code {(byte)code} ({CodeToMessage(code)}).") => Code = code;

        /// <summary>
        /// Modbus exception code.
        /// </summary>
        public ExceptionCode Code { get; set; }

        private static string CodeToMessage(ExceptionCode code)
        {
            switch (code)
            {
                case ExceptionCode.NoException:
                    return "No exception";
                case ExceptionCode.IllegalFunction:
                    return "Illegal Function";
                case ExceptionCode.IllegalDataAddress:
                    return "Illegal Data Address";
                case ExceptionCode.IllegalDataValue:
                    return "Illegal Data Value";
                case ExceptionCode.ServerDeviceFailure:
                    return "Server Device Failure";
                case ExceptionCode.Acknowledge:
                    return "Acknowledge";
                case ExceptionCode.ServerDeviceBusy:
                    return "Server Device Busy";
                case ExceptionCode.NegativeAcknowledge:
                    return "Negative Acknowledge";
                case ExceptionCode.MemoryParityError:
                    return "Memory Parity Error";
                case ExceptionCode.GatewayPathUnavailable:
                    return "Gateway Path Unavailable";
                case ExceptionCode.GatewayTargetDeviceFailedToRespond:
                    return "Gateway Target Device Failed to Respond";
                default:
                    return "Unknown";
            }
        }
    }
}

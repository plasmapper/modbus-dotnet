namespace PL.Modbus
{
    /// <summary>
    /// Modbus interface.
    /// </summary>
    public enum Interface { Serial, Network }

    /// <summary>
    /// Modbus protocol.
    /// </summary>
    public enum Protocol { Rtu, Ascii, Tcp }
    
    /// <summary>
    /// Modbus function code.
    /// </summary>
    public enum FunctionCode : byte
    {
        ReadCoils = 1,
        ReadDI = 2,
        ReadHR = 3,
        ReadIR = 4,
        WriteSingleCoil = 5,
        WriteSingleHR = 6,
        WriteMultipleCoils = 15,
        WriteMultipleHR = 16
    }
}

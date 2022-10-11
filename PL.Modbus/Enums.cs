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
        ReadDiscreteInputs = 2,
        ReadHoldingRegisters = 3,
        ReadInputRegisters = 4,
        WriteSingleCoil = 5,
        WriteSingleHoldingRegister = 6,
        WriteMultipleCoils = 15,
        WriteMultipleHoldingRegisters = 16
    }

    public enum ExceptionCode : byte
    {
        NoException = 0,
        IllegalFunction = 1,
        IllegalDataAddress = 2,
        IllegalDataValue = 3,
        ServerDeviceFailure = 4,
        Acknowledge = 5,
        ServerDeviceBusy = 6,
        NegativeAcknowledge = 7,
        MemoryParityError = 8,
        GatewayPathUnavailable = 10,
        GatewayTargetDeviceFailedToRespond = 11
    }
}

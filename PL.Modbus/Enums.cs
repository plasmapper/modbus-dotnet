namespace PL.Modbus
{
    /// <summary>
    /// Modbus interface.
    /// </summary>
    public enum Interface
    {
        /// <summary>
        /// Serial interface.
        /// </summary>
        Serial,
        
        /// <summary>
        /// Network interface.
        /// </summary>
        Network
    }

    /// <summary>
    /// Modbus protocol.
    /// </summary>
    public enum Protocol
    {
        /// <summary>
        /// Modbus RTU protocol.
        /// </summary>
        Rtu,

        /// <summary>
        /// Modbus ASCII protocol.
        /// </summary>
        Ascii,

        /// <summary>
        /// Modbus TCP protocol.
        /// </summary>
        Tcp
    }
    
    /// <summary>
    /// Modbus function code.
    /// </summary>
    public enum FunctionCode : byte
    {
        /// <summary>
        /// Read coils function code.
        /// </summary>
        ReadCoils = 1,

        /// <summary>
        /// Read discrete inputs function code.
        /// </summary>
        ReadDiscreteInputs = 2,

        /// <summary>
        /// Read holding registers function code.
        /// </summary>
        ReadHoldingRegisters = 3,

        /// <summary>
        /// Read input registers function code.
        /// </summary>
        ReadInputRegisters = 4,

        /// <summary>
        /// Write single coil function code.
        /// </summary>
        WriteSingleCoil = 5,

        /// <summary>
        /// Write single holding register function code.
        /// </summary>
        WriteSingleHoldingRegister = 6,

        /// <summary>
        /// Write multiple coils function code.
        /// </summary>
        WriteMultipleCoils = 15,

        /// <summary>
        /// Write multiple holding registers function code.
        /// </summary>
        WriteMultipleHoldingRegisters = 16
    }

    /// <summary>
    /// Modbus exception code.
    /// </summary>
    public enum ExceptionCode : byte
    {
        /// <summary>
        /// No exception code.
        /// </summary>
        NoException = 0,

        /// <summary>
        /// Illegal function exception code.
        /// </summary>
        IllegalFunction = 1,

        /// <summary>
        /// Illegal data address exception code.
        /// </summary>
        IllegalDataAddress = 2,

        /// <summary>
        /// Illegal data value exception code.
        /// </summary>
        IllegalDataValue = 3,

        /// <summary>
        /// Server device failure exception code.
        /// </summary>
        ServerDeviceFailure = 4,

        /// <summary>
        /// Acknowledge exception code.
        /// </summary>
        Acknowledge = 5,

        /// <summary>
        /// Server device busy exception code.
        /// </summary>
        ServerDeviceBusy = 6,

        /// <summary>
        /// Negative acknowledge exception code.
        /// </summary>
        NegativeAcknowledge = 7,

        /// <summary>
        /// Memory parity error exception code.
        /// </summary>
        MemoryParityError = 8,

        /// <summary>
        /// Gateway path unavailable exception code.
        /// </summary>
        GatewayPathUnavailable = 10,

        /// <summary>
        /// Gateway target device failed to respond exception code.
        /// </summary>
        GatewayTargetDeviceFailedToRespond = 11
    }
}

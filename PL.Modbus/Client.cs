using System.Text;
using System.Collections;
using System.IO.Ports;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus client.
    /// </summary>
    public class Client : IDisposable
    {
        private readonly Protocol _protocol;
        private readonly byte _stationAddress;

        private readonly Stream _stream;

        private ushort _tcpTransactionId = 0;

        /// <summary>
        /// Initializes a new instance of the Modbus client class with serial interface.
        /// </summary>
        /// <param name="serialPort">Serial port.</param>
        /// <param name="protocol">Modbus protocol.</param>
        /// <param name="stationAddress">Server station address.</param>
        public Client(SerialPort serialPort, Protocol protocol = Protocol.Rtu, byte stationAddress = 1)
        {
            _stream = new SerialStream(serialPort);
            _protocol = protocol;
            _stationAddress = stationAddress;
            if (protocol == Protocol.Rtu)
                _stream.DelayBeforeWrite = serialPort.BaudRate < 19200 ? 28000 / serialPort.BaudRate : 2;
        }

        /// <summary>
        /// Initializes a new instance of the Modbus client class with network interface.
        /// </summary>
        /// <param name="ipAddress">IP address.</param>
        /// <param name="port">Port.</param>
        /// <param name="protocol">Modbus protocol.</param>
        /// <param name="stationAddress">Server station address.</param>
        public Client(string ipAddress, ushort port = 502, Protocol protocol = Protocol.Tcp, byte stationAddress = 255)
        {
            _stream = new NetworkStream(ipAddress, port);
            _protocol = protocol;
            _stationAddress = stationAddress;
            if (protocol == Protocol.Rtu)
                _stream.DelayBeforeWrite = 2;
        }

        /// <summary>
        /// Gets and sets connect timeout, ms.
        /// </summary>
        public int ConnectTimeout
        {
            get => _stream.ConnectTimeout;
            set => _stream.ConnectTimeout = value;
        }

        /// <summary>
        /// Gets and sets stream read timeout, ms.
        /// </summary>
        public int ReadTimeout
        {
            get => _stream.ReadTimeout;
            set => _stream.ReadTimeout = value;
        }

        /// <summary>
        /// Gets and sets the delay between the end of the read operation and unlocking the stream, ms.
        /// </summary>
        public int DelayAfterRead = 0;

        public void Dispose()
        {
            _stream.Close();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Executes Modbus command.
        /// </summary>
        /// <param name="functionCode">Modbus function code.</param>
        /// <param name="data">Modbus data.</param>
        /// <returns></returns>
        public virtual byte[] Command(byte functionCode, byte[] data)
        {
            using (_stream.Lock())
            {
                _stream.Open();

                byte[] commandBuffer;
                byte[] responseBuffer = Array.Empty<byte>();
                bool responseError = false;

                switch (_protocol)
                {
                    case Protocol.Rtu:
                        commandBuffer = new byte[data.Length + 4];
                        commandBuffer[0] = _stationAddress;
                        commandBuffer[1] = functionCode;
                        data.CopyTo(commandBuffer, 2);
                        BitConverter.GetBytes(Utility.Crc(commandBuffer, data.Length + 2)).CopyTo(commandBuffer, data.Length + 2);
                        _stream.Write(commandBuffer);
                        
                        responseBuffer = _stream.Read(2);
                        break;

                    case Protocol.Ascii:
                        commandBuffer = new byte[data.Length + 3];
                        commandBuffer[0] = _stationAddress;
                        commandBuffer[1] = functionCode;
                        data.CopyTo(commandBuffer, 2);
                        commandBuffer[data.Length + 2] = Utility.Lrc(commandBuffer, data.Length + 2);
                        commandBuffer = Encoding.ASCII.GetBytes(":" + Utility.ByteArrayToAsciiString(commandBuffer) + "\r\n");
                        _stream.Write(commandBuffer);
                        
                        string responseString = Encoding.ASCII.GetString(_stream.ReadTo((byte)'\n'));
                        if (responseString[0] != ':' || responseString[^2..] != "\r\n")
                            responseError = true;
                        responseBuffer = Utility.AsciiStringToByteArray(responseString[1..^2]);
                        break;

                    case Protocol.Tcp:
                        commandBuffer = new byte[data.Length + 8];
                        BitConverter.GetBytes(_tcpTransactionId).CopyTo(commandBuffer, 0);
                        Array.Reverse(commandBuffer, 0, 2);
                        commandBuffer[2] = 0;
                        commandBuffer[3] = 0;
                        BitConverter.GetBytes(data.Length + 2).CopyTo(commandBuffer, 4);
                        Array.Reverse(commandBuffer, 4, 2);
                        commandBuffer[6] = _stationAddress;
                        commandBuffer[7] = functionCode;
                        data.CopyTo(commandBuffer, 8);
                        _stream.Write(commandBuffer);

                        byte[] responseHeader = _stream.Read(6);
                        Array.Reverse(responseHeader, 0, 2);
                        if (BitConverter.ToUInt16(responseHeader, 0) != _tcpTransactionId || BitConverter.ToUInt16(responseHeader, 2) != 0)
                            responseError = true;
                        Array.Reverse(responseHeader, 4, 2);
                        responseBuffer = _stream.Read(BitConverter.ToUInt16(responseHeader, 4));
                        _tcpTransactionId++;
                        break;
                }

                byte responseAddress = responseBuffer[0];
                byte responseFunctionCode = responseBuffer[1];

                if (responseError || responseAddress != _stationAddress || (responseFunctionCode & 127) != functionCode)
                {
                    _stream.ReadAvailableData();
                    if (DelayAfterRead > 0)
                        Thread.Sleep(DelayAfterRead);
                    throw new("Modbus response error.");
                }                    

                if (_protocol == Protocol.Rtu)
                {
                    byte[] rtuData = responseFunctionCode > 127 ? _stream.Read(1) : ReadRtuData(functionCode);
                    responseBuffer = new byte[rtuData.Length + 4];
                    responseBuffer[0] = responseAddress;
                    responseBuffer[1] = responseFunctionCode;
                    rtuData.CopyTo(responseBuffer, 2);
                    _stream.Read(2).CopyTo(responseBuffer, rtuData.Length + 2);
                }

                if ((_protocol == Protocol.Rtu && Utility.Crc(responseBuffer, responseBuffer.Length) != 0) ||
                    (_protocol == Protocol.Ascii && Utility.Lrc(responseBuffer, responseBuffer.Length) != 0))
                {
                    _stream.ReadAvailableData();
                    if (DelayAfterRead > 0)
                        Thread.Sleep(DelayAfterRead);
                    throw new("Modbus CRC error.");
                }                    

                if (DelayAfterRead > 0)
                    Thread.Sleep(DelayAfterRead);

                if (responseFunctionCode > 127)
                    throw new Exception((ExceptionCode)responseBuffer[2]);

                switch (_protocol)
                {
                    case Protocol.Rtu:
                        return responseBuffer[2..^2];
                    case Protocol.Ascii:
                        return responseBuffer[2..^1];
                    default:
                        return responseBuffer[2..];
                }
            }
        }

        /// <summary>
        /// Reads coils.
        /// </summary>
        /// <param name="address">First coil address.</param>
        /// <param name="count">Number of coils to read.</param>
        /// <returns>Coil values.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        public List<bool> ReadCoils(ushort address, ushort count)
        {
            if (count == 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (address + count > 0x10000)
                throw new ArgumentException("Coil address range should be inside 0..65535.");
            return ReadBits(1, address, count);
        }

        /// <summary>
        /// Reads discrete inputs.
        /// </summary>
        /// <param name="address">First discrete input address.</param>
        /// <param name="count">Number of discrete inputs to read.</param>
        /// <returns>Discrete inputs.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        public List<bool> ReadDiscreteInputs(ushort address, ushort count)
        {
            if (count == 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (address + count > 0x10000)
                throw new ArgumentException("Discrete input address range should be inside 0..65535.");
            return ReadBits(2, address, count);
        }

        /// <summary>
        /// Reads holding registers.
        /// </summary>
        /// <param name="address">First holding register address.</param>
        /// <param name="count">Number of holding registers to read.</param>
        /// <returns>Holding registers.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        public List<ushort> ReadHoldingRegisters(ushort address, ushort count)
        {
            if (count == 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (address + count > 0x10000)
                throw new ArgumentException("Holding register address range should be inside 0..65535.");
            return ReadRegisters(3, address, count);
        }

        /// <summary>
        /// Reads input registers.
        /// </summary>
        /// <param name="address">First input register address.</param>
        /// <param name="count">Number of input registers to read.</param>
        /// <returns>Input registers.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        public List<ushort> ReadInputRegisters(ushort address, ushort count)
        {
            if (count == 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            if (address + count > 0x10000)
                throw new ArgumentException("Input register address range should be inside 0..65535.");
            return ReadRegisters(4, address, count);
        }

        /// <summary>
        /// Writes single coil.
        /// </summary>
        /// <param name="address">Coil address.</param>
        /// <param name="value">Coil value.</param>
        public void WriteSingleCoil(ushort address, bool value)
        {
            byte[] commandData = new byte[4];
            BitConverter.GetBytes(address).CopyTo(commandData, 0);
            Array.Reverse(commandData, 0, 2);
            commandData[2] = (byte)(value ? 0xFF : 0);
            commandData[3] = 0;
            Command(5, commandData);
        }

        /// <summary>
        /// Writes single holding register.
        /// </summary>
        /// <param name="address">Holding register address.</param>
        /// <param name="value">Holding register value.</param>
        public void WriteSingleHoldingRegister(ushort address, ushort value)
        {
            byte[] commandData = new byte[4];
            BitConverter.GetBytes(address).CopyTo(commandData, 0);
            Array.Reverse(commandData, 0, 2);
            BitConverter.GetBytes(value).CopyTo(commandData, 2);
            Array.Reverse(commandData, 2, 2);
            Command(6, commandData);
        }

        /// <summary>
        /// Writes multiple coils.
        /// </summary>
        /// <param name="address">First coil address.</param>
        /// <param name="values">Coil values.</param>
        /// <exception cref="ArgumentOutOfRangeException">Values.Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        public void WriteMultipleCoils(ushort address, List<bool> values)
        {
            if (values.Count == 0)
                throw new ArgumentOutOfRangeException(nameof(values));
            if (address + values.Count > 0x10000)
                throw new ArgumentException("Coil address range should be inside 0..65535.");

            foreach (var addressRange in Utility.SplitAddressRange(address, (ushort)values.Count, 1968))
            {
                byte byteCount = (byte)((addressRange.NumberOfItems - 1) / 8 + 1);
                byte[] commandData = new byte[byteCount + 5];
                BitConverter.GetBytes(addressRange.Address).CopyTo(commandData, 0);
                Array.Reverse(commandData, 0, 2);
                BitConverter.GetBytes(addressRange.NumberOfItems).CopyTo(commandData, 2);
                Array.Reverse(commandData, 2, 2);
                commandData[4] = byteCount;
                new BitArray(values.GetRange(addressRange.Address - address, addressRange.NumberOfItems).ToArray()).CopyTo(commandData, 5);
                Command(15, commandData);
            }
        }

        /// <summary>
        /// Writes multiple holding registers.
        /// </summary>
        /// <param name="address">First holding register address.</param>
        /// <param name="values">Holding register values.</param>
        /// <exception cref="ArgumentOutOfRangeException">VAlues.Count is 0.</exception>
        /// <exception cref="ArgumentException">(Address + count) > 65536.</exception>
        public void WriteMultipleHoldingRegisters(ushort address, List<ushort> values)
        {
            if (values.Count == 0)
                throw new ArgumentOutOfRangeException(nameof(values));
            if (address + values.Count > 0x10000)
                throw new ArgumentException("Holding register address range should be inside 0..65535.");

            foreach (var addressRange in Utility.SplitAddressRange(address, (ushort)values.Count, 123))
            {
                byte byteCount = (byte)(addressRange.NumberOfItems * 2);
                byte[] commandData = new byte[byteCount + 5];
                BitConverter.GetBytes(addressRange.Address).CopyTo(commandData, 0);
                Array.Reverse(commandData, 0, 2);
                BitConverter.GetBytes(addressRange.NumberOfItems).CopyTo(commandData, 2);
                Array.Reverse(commandData, 2, 2);
                commandData[4] = byteCount;
                for (int i = 0; i < addressRange.NumberOfItems; i++)
                {
                    BitConverter.GetBytes(values[i]).CopyTo(commandData, 5 + i * 2);
                    Array.Reverse(commandData, 5 + i * 2, 2);
                }
                Command(16, commandData);
            }
        }

        /// <summary>
        /// Reads data from Modbus stream.
        /// </summary>
        /// <param name="byteCount">Number of bytes to read.</param>
        /// <returns>Data buffer.</returns>
        protected byte[] Read(byte byteCount) => _stream.Read(byteCount);

        /// <summary>
        /// Reads response data when using Modbus RTU protocol.
        /// </summary>
        /// <param name="functionCode">Modbus function code.</param>
        /// <returns>Data buffer.</returns>
        protected virtual byte[] ReadRtuData(byte functionCode)
        {
            switch (functionCode)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    byte byteCount = Read(1)[0];
                    byte[] dataBuffer = new byte[byteCount + 1];
                    dataBuffer[0] = byteCount;
                    Read(byteCount).CopyTo(dataBuffer, 1);
                    return dataBuffer;
                case 5:
                case 6:
                case 15:
                case 16:
                    return Read(4);
            }

            _stream.ReadAvailableData();
            if (DelayAfterRead > 0)
                Thread.Sleep(DelayAfterRead);
            throw new("Unknown Modbus function code.");
        }

        private List<bool> ReadBits(byte functionCode, ushort address, ushort numberOfBits)
        {
            List<bool> bits = new();
            foreach (var addressRange in Utility.SplitAddressRange(address, numberOfBits, 2000))
            {
                byte[] commandData = new byte[4];
                BitConverter.GetBytes(addressRange.Address).CopyTo(commandData, 0);
                Array.Reverse(commandData, 0, 2);
                BitConverter.GetBytes(addressRange.NumberOfItems).CopyTo(commandData, 2);
                Array.Reverse(commandData, 2, 2);

                BitArray responseData = new(Command(functionCode, commandData)[1..]);

                int maxIndex = Math.Min(addressRange.NumberOfItems, responseData.Length);
                for (int j = 0; j < maxIndex; j++)
                    bits.Add(responseData[j]);
            }
            return bits;
        }

        private List<ushort> ReadRegisters(byte functionCode, ushort address, ushort numberOfRegisters)
        {
            List<ushort> registers = new();
            foreach (var addressRange in Utility.SplitAddressRange(address, numberOfRegisters, 125))
            {
                byte[] commandData = new byte[4];
                BitConverter.GetBytes(addressRange.Address).CopyTo(commandData, 0);
                Array.Reverse(commandData, 0, 2);
                BitConverter.GetBytes(addressRange.NumberOfItems).CopyTo(commandData, 2);
                Array.Reverse(commandData, 2, 2);

                byte[] responseData = Command(functionCode, commandData)[1..];

                int maxIndex = Math.Min(addressRange.NumberOfItems * 2, responseData.Length / 2 * 2);
                for (int j = 0; j < maxIndex; j+=2)
                {
                    Array.Reverse(responseData, j, 2);
                    registers.Add(BitConverter.ToUInt16(responseData, j));
                }
            }
            return registers;
        }
    }    
}
using System.IO.Ports;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus data stream that uses SerialPort.
    /// </summary>
    internal class SerialStream : Stream
    {
        private readonly SerialPort _serialPort;

        /// <summary>
        /// Initializes a new instance of the SerialStream class.
        /// </summary>
        /// <param name="serialPort">Serial port.</param>
        public SerialStream(SerialPort serialPort) => _serialPort = serialPort;

        /// <summary>
        /// Reads data from a serial stream. Timeout is increased depending on the number of bytes to read and baud rate.
        /// </summary>
        /// <param name="byteCount">Number of bytes to read.</param>
        /// <returns>Read buffer.</returns>
        public override byte[] Read(int byteCount)
        {
            byte[] buffer = new byte[byteCount];
            int offset = 0;
            _serialPort.ReadTimeout = _serialPort.BaudRate == 0 ? Timeout : Timeout + byteCount * 11 * 1000 / _serialPort.BaudRate;
            while (byteCount > 0)
            {
                int bytesRead = _serialPort.Read(buffer, offset, byteCount);
                offset += bytesRead;
                byteCount -= bytesRead;
            }     
            return buffer;
        }

        public override void Write(byte[] buffer)
        {
            if (DelayBeforeWrite > 0)
                Thread.Sleep(DelayBeforeWrite);
            byte[] bytesToRead = new byte[_serialPort.BytesToRead];
            _serialPort.Read(bytesToRead, 0, bytesToRead.Length);
            _serialPort.WriteTimeout = _serialPort.BaudRate == 0 ? Timeout : Timeout + buffer.Length * 11 * 1000 / _serialPort.BaudRate;
            _serialPort.Write(buffer, 0, buffer.Length);
        }

        public override void Open()
        {
            if (!_serialPort.IsOpen)
                _serialPort.Open();
        }

        public override void Close() { }

        public override IDisposable Lock() => new SerialPortLock(_serialPort);

        private class SerialPortLock : IDisposable
        {
            SerialPort _serialPort;

            public SerialPortLock(SerialPort serialPort)
            {
                _serialPort = serialPort;
                Monitor.Enter(_serialPort);
            }

            public void Dispose() =>
                Monitor.Exit(_serialPort);
        }
    }
}
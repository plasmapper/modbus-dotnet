using System;
using System.Threading;
using System.IO.Ports;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus data stream that uses SerialPort.
    /// </summary>
    public class SerialStream : Stream
    {
        /// <summary>
        /// Initializes a new instance of the SerialStream class.
        /// </summary>
        /// <param name="port">Serial port.</param>
        public SerialStream(SerialPort port) => Port = port;

        /// <summary>
        /// Gets the serial port.
        /// </summary>
        public SerialPort Port { get; }

        /// <summary>
        /// Reads a sequence of bytes from the stream.
        /// </summary>
        /// <param name="byteCount">The number of bytes to be read from the stream.</param>
        /// <returns>Bytes read from the stream.</returns>
        public override byte[] Read(int byteCount)
        {
            byte[] buffer = new byte[byteCount];
            int offset = 0;
            Port.ReadTimeout = Port.BaudRate == 0 ? ReadTimeout : ReadTimeout + byteCount * 11 * 1000 / Port.BaudRate;
            while (byteCount > 0)
            {
                int bytesRead = Port.Read(buffer, offset, byteCount);
                offset += bytesRead;
                byteCount -= bytesRead;
            }     
            return buffer;
        }

        /// <summary>
        /// Reads all available bytes from the stream.
        /// </summary>
        public override void ReadAvailableData()
        {
            if (Port.BytesToRead == 0)
                return;
            Port.ReadTimeout = 1;
            try
            {
                while (true)
                    Port.ReadByte();
            }
            catch { }
        }

        /// <summary>
        /// Writes a sequence of bytes to the stream.
        /// </summary>
        /// <param name="buffer">Bytes to write to the stream.</param>
        public override void Write(byte[] buffer)
        {
            ReadAvailableData();
            if (DelayBeforeWrite > 0)
                Thread.Sleep(DelayBeforeWrite);
            Port.WriteTimeout = Port.BaudRate == 0 ? WriteTimeout : WriteTimeout + buffer.Length * 11 * 1000 / Port.BaudRate;
            Port.Write(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Opens the stream.
        /// </summary>
        public override void Open()
        {
            if (!Port.IsOpen)
                Port.Open();
        }

        /// <summary>
        /// Closes the stream.
        /// </summary>
        public override void Close() { }

        /// <summary>
        /// Acquires an exclusive lock on the stream and returns an object that releases the lock when disposed.
        /// </summary>
        /// <returns>Disposable lock.</returns>
        public override IDisposable Lock() => new SerialPortLock(Port);

        private class SerialPortLock : IDisposable
        {
            private readonly SerialPort _serialPort;

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
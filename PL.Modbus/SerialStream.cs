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

        public SerialPort Port { get; }

        /// <summary>
        /// Reads data from a serial stream. Timeout is increased depending on the number of bytes to read and baud rate.
        /// </summary>
        /// <param name="byteCount">Number of bytes to read.</param>
        /// <returns>Read buffer.</returns>
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

        public override void Write(byte[] buffer)
        {
            ReadAvailableData();
            if (DelayBeforeWrite > 0)
                Thread.Sleep(DelayBeforeWrite);
            Port.Write(buffer, 0, buffer.Length);
        }

        public override void Open()
        {
            if (!Port.IsOpen)
                Port.Open();
        }

        public override void Close() { }

        public override IDisposable Lock() => new SerialPortLock(Port);

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
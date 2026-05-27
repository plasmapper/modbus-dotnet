using System;
using System.Threading;
using System.Net.Sockets;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus data stream that uses TcpClient.
    /// </summary>
    public class NetworkStream : Stream
    {
        private readonly string _ipAddress;
        private readonly ushort _port;
        private TcpClient _tcpClient = new TcpClient();

        /// <summary>
        /// Initializes a new instance of the NetworkStream class.
        /// </summary>
        /// <param name="ipAddress">IP address.</param>
        /// <param name="port">Port.</param>
        public NetworkStream(string ipAddress, ushort port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        /// <summary>
        /// Reads a sequence of bytes from the stream.
        /// </summary>
        /// <param name="byteCount">The number of bytes to be read from the stream.</param>
        /// <returns>Bytes read from the stream.</returns>
        public override byte[] Read(int byteCount)
        {
            byte[] buffer = new byte[byteCount];
            _tcpClient.ReceiveTimeout = ReadTimeout;
            _tcpClient.GetStream().Read(buffer, 0, byteCount);
            return buffer;
        }

        /// <summary>
        /// Reads all available bytes from the stream.
        /// </summary>
        public override void ReadAvailableData()
        {
            if (!_tcpClient.GetStream().DataAvailable)
                return;
            _tcpClient.ReceiveTimeout = 1;
            try
            {
                while (true)
                    _tcpClient.GetStream().ReadByte();
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
            _tcpClient.SendTimeout = WriteTimeout;
            _tcpClient.GetStream().Write(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Opens the stream.
        /// </summary>
        public override void Open()
        {
            if (!_tcpClient.Connected)
            {
                _tcpClient.Dispose();
                _tcpClient = new TcpClient();
                if (!_tcpClient.ConnectAsync(_ipAddress, _port).Wait(ConnectTimeout))
                    throw new SocketException(10060);
                _tcpClient.NoDelay = true;
            }                
        }

        /// <summary>
        /// Closes the stream.
        /// </summary>
        public override void Close() =>
            _tcpClient.Dispose();

        /// <summary>
        /// Acquires an exclusive lock on the stream and returns an object that releases the lock when disposed.
        /// </summary>
        /// <returns>Disposable lock.</returns>
        public override IDisposable Lock() => new NetworkStreamLock(this);

        private class NetworkStreamLock : IDisposable
        {
            private readonly NetworkStream _networkStream;

            public NetworkStreamLock(NetworkStream networkStream)
            {
                _networkStream = networkStream;
                Monitor.Enter(_networkStream);
            }

            public void Dispose() =>
                Monitor.Exit(_networkStream);
        }
    }
}

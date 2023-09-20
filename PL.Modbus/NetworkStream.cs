using System;
using System.Threading;
using System.Net.Sockets;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus data stream that uses TcpClient.
    /// </summary>
    internal class NetworkStream : Stream
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

        public override byte[] Read(int byteCount)
        {
            byte[] buffer = new byte[byteCount];
            _tcpClient.ReceiveTimeout = ReadTimeout;
            _tcpClient.GetStream().Read(buffer, 0, byteCount);
            return buffer;
        }

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

        public override void Write(byte[] buffer)
        {
            ReadAvailableData();
            if (DelayBeforeWrite > 0)
                Thread.Sleep(DelayBeforeWrite);
            _tcpClient.GetStream().Write(buffer, 0, buffer.Length);
        }

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

        public override void Close() =>
            _tcpClient.Dispose();

        public override IDisposable Lock() => new NetworkStreamLock(this);

        private class NetworkStreamLock : IDisposable
        {
            NetworkStream _networkStream;

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

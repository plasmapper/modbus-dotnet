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
        private TcpClient _tcpClient = new();

        /// <summary>
        /// Initializes a new instance of the NetworkStream class.
        /// </summary>
        /// <param name="ipAddress">IP address.</param>
        /// <param name="port">Port.</param>
        /// <param name="timeout">Read/write timeout, ms.</param>
        public NetworkStream(string ipAddress, ushort port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public override byte[] Read(int byteCount)
        {
            byte[] buffer = new byte[byteCount];
            _tcpClient.ReceiveTimeout = Timeout;
            _tcpClient.GetStream().Read(buffer, 0, byteCount);
            return buffer;
        }

        public override void Write(byte[] buffer)
        {
            if (DelayBeforeWrite > 0)
                Thread.Sleep(DelayBeforeWrite);
            _tcpClient.SendTimeout = Timeout;
            _tcpClient.GetStream().Write(buffer, 0, buffer.Length);
        }

        public override void Open()
        {
            if (!_tcpClient.Connected)
            {
                _tcpClient.Dispose();
                _tcpClient = new(_ipAddress, _port);
            }                
        }

        public override void Close() =>
            _tcpClient.Dispose();

        public override IDisposable Lock() => new DisposableLock();

        private class DisposableLock : IDisposable
        {
            public void Dispose() { }
        }
    }
}

using System;
using System.Collections.Generic;

namespace PL.Modbus
{
    /// <summary>
    /// Modbus data stream.
    /// </summary>
    public abstract class Stream : IDisposable
    {
        private bool _disposed = false;

        public int ConnectTimeout { get; set; } = 1000;

        public int ReadTimeout { get; set; } = 300;

        public int WriteTimeout { get; set; } = 300;

        public int DelayBeforeWrite { get; set; } = 0;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                Close();

            _disposed = true;
        }

        public abstract byte[] Read(int byteCount);

        public byte[] ReadTo(byte termByte)
        {
            List<byte> buffer = new List<byte>();
            do
            {
                buffer.Add(Read(1)[0]);
            } while (buffer[buffer.Count - 1] != termByte);
            return buffer.ToArray();
        }

        public abstract void ReadAvailableData();

        public abstract void Write(byte[] buffer);

        public abstract void Open();

        public abstract void Close();

        public abstract IDisposable Lock();
    }
}
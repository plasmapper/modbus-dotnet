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

        /// <summary>
        /// Gets and sets connect timeout, ms.
        /// </summary>
        public int ConnectTimeout { get; set; } = 1000;

        /// <summary>
        /// Gets and sets read timeout, ms.
        /// </summary>
        public int ReadTimeout { get; set; } = 300;

        /// <summary>
        /// Gets and sets write timeout, ms.
        /// </summary>
        public int WriteTimeout { get; set; } = 300;

        /// <summary>
        /// Gets and sets the delay between the end of the read operation and unlocking the stream, ms.
        /// </summary>
        public int DelayBeforeWrite { get; set; } = 0;

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// When overridden in a derived class, reads a sequence of bytes from the stream.
        /// </summary>
        /// <param name="byteCount">The number of bytes to be read from the stream.</param>
        /// <returns>Bytes read from the stream.</returns>
        public abstract byte[] Read(int byteCount);

        /// <summary>
        /// Reads a sequence of bytes up to the specified value from the stream.
        /// </summary>
        /// <param name="termByte">A value that indicates where the read operation stops.</param>
        /// <returns>Bytes read from the stream.</returns>
        public byte[] ReadTo(byte termByte)
        {
            List<byte> buffer = new List<byte>();
            do
            {
                buffer.Add(Read(1)[0]);
            } while (buffer[buffer.Count - 1] != termByte);
            return buffer.ToArray();
        }

        /// <summary>
        /// When overridden in a derived class, reads all available bytes from the stream.
        /// </summary>
        public abstract void ReadAvailableData();

        /// <summary>
        /// When overridden in a derived class, writes a sequence of bytes to the stream.
        /// </summary>
        /// <param name="buffer">Bytes to write to the stream.</param>
        public abstract void Write(byte[] buffer);

        /// <summary>
        /// When overridden in a derived class, opens the stream.
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// When overridden in a derived class, closes the stream.
        /// </summary>
        public abstract void Close();

        /// <summary>
        /// When overridden in a derived class, acquires an exclusive lock on the stream and returns an object that releases the lock when disposed.
        /// </summary>
        /// <returns>Disposable lock.</returns>
        public abstract IDisposable Lock();

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">True if the method call comes from a Dispose method and false if it comes from a finalizer.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                Close();

            _disposed = true;
        }
    }
}
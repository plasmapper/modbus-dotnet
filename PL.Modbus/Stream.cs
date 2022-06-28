namespace PL.Modbus
{
    internal abstract class Stream
    {
        public int Timeout { get; set; } = 300;

        public int DelayBeforeWrite { get; set; } = 0;

        public abstract byte[] Read(int byteCount);

        public byte[] ReadTo(byte termByte)
        {
            List<byte> buffer = new();
            do
            {
                buffer.Add(Read(1)[0]);
            } while (buffer[buffer.Count - 1] != termByte);
            return buffer.ToArray();
        }

        public abstract void Write(byte[] buffer);

        public abstract void Open();

        public abstract void Close();

        public abstract IDisposable Lock();
    }
}
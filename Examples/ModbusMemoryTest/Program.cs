using System.IO.Ports;

using PL.Tree;
using PL.Modbus;

namespace ModbusMemoryTest
{
    internal class SerialSettings : ClassNode
    {
        public ValueNode<string> PortName { get; } = new("");
        public ValueNode<Protocol> Protocol { get; } = new(PL.Modbus.Protocol.Rtu);
        public ValueNode<byte> StationAddress { get; } = new(1);
        public ValueNode<int> BaudRate { get; } = new(9600);
        public ValueNode<ushort> DataBits { get; } = new(8);
        public ValueNode<Parity> Parity { get; } = new(System.IO.Ports.Parity.Even);
        public ValueNode<StopBits> StopBits { get; } = new(System.IO.Ports.StopBits.One);
        public ValueNode<Handshake> Handshake { get; } = new(System.IO.Ports.Handshake.None);
    }

    internal class NetworkSettings : ClassNode
    {
        public ValueNode<string> IpAddress { get; } = new("");
        public ValueNode<ushort> Port { get; } = new(502);
        public ValueNode<byte> StationAddress { get; } = new(255);
    }

    internal enum Method { ReadCoils, ReadDiscreteInputs, ReadHoldingRegisters, ReadInputRegisters }

    internal static class Parameters
    {
        public static ValueNode<Interface> Interface { get; } = new(PL.Modbus.Interface.Serial);
        public static ValueNode<int> Timeout { get; } = new(300);
        public static ValueNode<bool> Hex { get; } = new();

        public static SerialSettings SerialSettings { get; } = new();
        public static NetworkSettings NetworkSettings { get; } = new();

        public static ValueNode<ushort> NumberOfCoils { get; } = new(800);
        public static ValueNode<ushort> NumberOfHoldingRegisters { get; } = new(50);
        public static ValueNode<ushort> NumberOfIterations { get; } = new(100);
        public static ValueNode<bool> Start { get; } = new();

        public static ValueNode<string> Command { get; } = new();
        public static ValueNode<int> Progress { get; } = new();

        public static ValueNode<bool> Exit { get; } = new();
    }

    internal static class Program
    {
        private static Form? _form;

        [STAThread]
        static void Main()
        {
            new Thread(TestMemory).Start();

            ApplicationConfiguration.Initialize();
            _form = new Form();
            Application.Run(_form);
        }

        public static void TestMemory()
        {
            SerialPort? serialPort = null;
            Client? client = null;

            while (!Parameters.Exit.Value)
            {
                if (Parameters.Start.Value)
                {
                    try
                    {
                        if (Parameters.Interface.Value == Interface.Serial)
                        {
                            serialPort = new(Parameters.SerialSettings.PortName.Value,
                                Parameters.SerialSettings.BaudRate.Value,
                                Parameters.SerialSettings.Parity.Value,
                                Parameters.SerialSettings.DataBits.Value,
                                Parameters.SerialSettings.StopBits.Value);
                            serialPort.Handshake = Parameters.SerialSettings.Handshake.Value;
                            client = new(serialPort, Parameters.SerialSettings.Protocol.Value, Parameters.SerialSettings.StationAddress.Value);
                        }
                        else
                            client = new(Parameters.NetworkSettings.IpAddress.Value, Parameters.NetworkSettings.Port.Value, Protocol.Tcp, Parameters.NetworkSettings.StationAddress.Value);

                        client.ReadTimeout = Parameters.Timeout.Value;

                        var random = new Random();

                        List<bool> coils = client.ReadCoils(0, Parameters.NumberOfCoils.Value);
                        for (int i = 0; i < Parameters.NumberOfIterations.Value && Parameters.Start.Value; i++)
                        {
                            ushort address = (ushort)random.Next(Parameters.NumberOfCoils.Value);
                            bool value = random.Next(2) > 0;
                            Parameters.Command.Value = $"Write single coil #{address}";
                            client.WriteSingleCoil(address, value);
                            coils[address] = value;
                            List<bool> newCoils = client.ReadCoils(0, Parameters.NumberOfCoils.Value);
                            if (!coils.SequenceEqual(newCoils))
                                throw new System.Exception("Memory readback error.");
                            coils = newCoils;
                            Parameters.Progress.Value = (i + 1) * 100 / Parameters.NumberOfIterations.Value;
                        }

                        List<ushort> holdingRegisters = client.ReadHoldingRegisters(0, Parameters.NumberOfHoldingRegisters.Value);
                        for (int i = 0; i < Parameters.NumberOfIterations.Value && Parameters.Start.Value; i++)
                        {
                            ushort address = (ushort)random.Next(Parameters.NumberOfHoldingRegisters.Value);
                            ushort value = (ushort)random.Next(0x10000);
                            Parameters.Command.Value = $"Write single HR #{address}";
                            client.WriteSingleHoldingRegister(address, value);
                            holdingRegisters[address] = value;
                            List<ushort> newHoldingRegisters = client.ReadHoldingRegisters(0, Parameters.NumberOfHoldingRegisters.Value);
                            if (!holdingRegisters.SequenceEqual(newHoldingRegisters))
                                throw new System.Exception("Memory readback error.");
                            holdingRegisters = newHoldingRegisters;
                            Parameters.Progress.Value = (i + 1) * 100 / Parameters.NumberOfIterations.Value;
                        }

                        coils = client.ReadCoils(0, Parameters.NumberOfCoils.Value);
                        for (int i = 0; i < Parameters.NumberOfIterations.Value && Parameters.Start.Value; i++)
                        {
                            ushort address = (ushort)random.Next(Parameters.NumberOfCoils.Value);
                            ushort count = (ushort)(random.Next(Parameters.NumberOfCoils.Value - address) + 1);
                            List<bool> values = new();
                            for (int j = 0; j < count; j++)
                                values.Add(random.Next(2) > 0);
                            Parameters.Command.Value = $"Write multiple coils ##{address}...{address + count}";
                            client.WriteMultipleCoils(address, values);
                            coils.RemoveRange(address, count);
                            coils.InsertRange(address, values);
                            List<bool> newCoils = client.ReadCoils(0, Parameters.NumberOfCoils.Value);
                            if (!coils.SequenceEqual(newCoils))
                                throw new System.Exception("Memory readback error.");
                            coils = newCoils;
                            Parameters.Progress.Value = (i + 1) * 100 / Parameters.NumberOfIterations.Value;
                        }

                        holdingRegisters = client.ReadHoldingRegisters(0, Parameters.NumberOfHoldingRegisters.Value);
                        for (int i = 0; i < Parameters.NumberOfIterations.Value && Parameters.Start.Value; i++)
                        {
                            ushort address = (ushort)random.Next(Parameters.NumberOfHoldingRegisters.Value);
                            ushort count = (ushort)(random.Next(Parameters.NumberOfHoldingRegisters.Value - address) + 1);
                            List<ushort> values = new();
                            for (int j = 0; j < count; j++)
                                values.Add((ushort)random.Next(0x10000));
                            Parameters.Command.Value = $"Write multiple HR ##{address}...{address + count}";
                            client.WriteMultipleHoldingRegisters(address, values);
                            holdingRegisters.RemoveRange(address, count);
                            holdingRegisters.InsertRange(address, values);
                            List<ushort> newHoldingRegisters = client.ReadHoldingRegisters(0, Parameters.NumberOfHoldingRegisters.Value);
                            if (!holdingRegisters.SequenceEqual(newHoldingRegisters))
                                throw new System.Exception("Memory readback error.");
                            holdingRegisters = newHoldingRegisters;
                            Parameters.Progress.Value = (i + 1) * 100 / Parameters.NumberOfIterations.Value;
                        }
                    }
                    catch (System.Exception exception)
                    {
                        _form?.Invoke(() => _form.ShowError(exception));
                    }
                    finally
                    {
                        try
                        {
                            client?.Dispose();
                            serialPort?.Close();
                        }
                        finally
                        {
                            client = null;
                            serialPort = null;
                        }

                        Parameters.Start.Value = false;
                    }
                }
                else
                    Thread.Sleep(100);
            }

            _form?.Invoke(() => _form.Close());
        }
    }
}
using System.IO.Ports;

using PL.Tree;
using PL.Modbus;

namespace ModbusSpeedTest
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

        public static ValueNode<Method> Method { get; } = new();
        public static ValueNode<ushort> DataAddress { get; } = new();
        public static ValueNode<ushort> NumberOfItems { get; } = new(1);
        public static ValueNode<bool> Start { get; } = new();

        public static ValueNode<int> NumberOfTransactions { get; } = new();
        public static ValueNode<int> NumberOfErrors { get; } = new();
        public static ValueNode<int> TransactionTime { get; } = new();
        public static ValueNode<string> Error { get; } = new();

        public static ValueNode<bool> Exit { get; } = new();
    }

    internal static class Program
    {
        private static Form? _form;

        [STAThread]
        static void Main()
        {
            new Thread(TestSpeed).Start();

            ApplicationConfiguration.Initialize();
            _form = new Form();
            Application.Run(_form);
        }

        public static void TestSpeed()
        {
            SerialPort? serialPort = null;
            Client? client = null;

            while (!Parameters.Exit.Value)
            {
                if (Parameters.Start.Value)
                {
                    try
                    {
                        Parameters.NumberOfTransactions.Value = 0;
                        Parameters.NumberOfErrors.Value = 0;

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

                        while (Parameters.Start.Value)
                        {
                            int transactionStartTime = Environment.TickCount;
                            try
                            {
                                switch (Parameters.Method.Value)
                                {
                                    case Method.ReadCoils:
                                        client.ReadCoils(Parameters.DataAddress.Value, Parameters.NumberOfItems.Value);
                                        break;
                                    case Method.ReadDiscreteInputs:
                                        client.ReadDiscreteInputs(Parameters.DataAddress.Value, Parameters.NumberOfItems.Value);
                                        break;
                                    case Method.ReadHoldingRegisters:
                                        client.ReadHoldingRegisters(Parameters.DataAddress.Value, Parameters.NumberOfItems.Value);
                                        break;
                                    case Method.ReadInputRegisters:
                                        client.ReadInputRegisters(Parameters.DataAddress.Value, Parameters.NumberOfItems.Value);
                                        break;
                                }

                                Parameters.Error.Value = "";
                            }
                            catch (System.Exception exception)
                            {
                                Parameters.Error.Value = exception.Message;
                                Parameters.NumberOfErrors.Value++;
                            }
                            finally
                            {
                                Parameters.NumberOfTransactions.Value++;
                                Parameters.TransactionTime.Value = Environment.TickCount - transactionStartTime;
                            }
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
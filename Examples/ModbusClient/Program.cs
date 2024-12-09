using System.IO.Ports;

using PL.Tree;
using PL.Modbus;

namespace ModbusClient
{
    internal class SerialSettings : ClassNode
    {
        public ValueNode<string> PortName { get; } = new("");
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

    internal class MultipleElements<T> : ClassNode
    {
        public ValueNode<ushort> Address { get; } = new();
        public ValueNode<ushort> Count { get; } = new(1);
        public ValueListNode<T> Values { get; } = new();
    }

    internal class SingleElement<T> : ClassNode
    {
        public ValueNode<ushort> Address { get; } = new();
        public ValueNode<T> Value { get; } = new();
    }

    internal static class Parameters
    {
        public static ValueNode<Interface> Interface { get; } = new(PL.Modbus.Interface.Serial);
        public static ValueNode<int> ConnectTimeout { get; } = new(1000);
        public static ValueNode<int> ReadTimeout { get; } = new(300);
        public static ValueNode<bool> Hex { get; } = new();

        public static SerialSettings SerialSettings { get; } = new();
        public static NetworkSettings NetworkSettings { get; } = new();
        public static ValueNode<Protocol> Protocol { get; } = new(PL.Modbus.Protocol.Rtu);

        public static MultipleElements<bool> Coils { get; } = new();
        public static SingleElement<bool> Coil { get; } = new();

        public static MultipleElements<bool> DiscreteInputs { get; } = new();

        public static MultipleElements<ushort> HoldingRegisters { get; } = new();
        public static SingleElement<ushort> HoldingRegister { get; } = new();

        public static MultipleElements<ushort> InputRegisters { get; } = new();
    }

    internal enum ModbusCommand {
        ReadCoils,
        WriteMultipleCoils,
        WriteSingleCoil,
        ReadDiscreteInputs,
        ReadHoldingRegisters,
        WriteMultipleHoldingRegisters,
        WriteSingleHoldingRegister,
        ReadInputRegisters
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }

        public static void ExecuteModbusCommand (ModbusCommand command)
        {
            SerialPort? serialPort = null;
            Client? client = null;

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
                    client = new(serialPort, Parameters.Protocol.Value, Parameters.SerialSettings.StationAddress.Value);
                }
                else
                    client = new(Parameters.NetworkSettings.IpAddress.Value, Parameters.NetworkSettings.Port.Value, Parameters.Protocol.Value, Parameters.NetworkSettings.StationAddress.Value);

                client.ConnectTimeout = Parameters.ConnectTimeout.Value;
                client.ReadTimeout = Parameters.ReadTimeout.Value;

                switch (command)
                {
                    case ModbusCommand.ReadCoils:
                        Parameters.Coils.Values.SetValue(client.ReadCoils(Parameters.Coils.Address.Value, Parameters.Coils.Count.Value));
                        break;
                    case ModbusCommand.WriteMultipleCoils:
                        client.WriteMultipleCoils(Parameters.Coils.Address.Value, Parameters.Coils.Values.ToList());
                        break;
                    case ModbusCommand.WriteSingleCoil:
                        client.WriteSingleCoil(Parameters.Coil.Address.Value, Parameters.Coil.Value.Value);
                        break;
                    case ModbusCommand.ReadDiscreteInputs:
                        Parameters.DiscreteInputs.Values.SetValue(client.ReadDiscreteInputs(Parameters.DiscreteInputs.Address.Value, Parameters.DiscreteInputs.Count.Value));
                        break;
                    case ModbusCommand.ReadHoldingRegisters:
                        Parameters.HoldingRegisters.Values.SetValue(client.ReadHoldingRegisters(Parameters.HoldingRegisters.Address.Value, Parameters.HoldingRegisters.Count.Value));
                        break;
                    case ModbusCommand.WriteMultipleHoldingRegisters:
                        client.WriteMultipleHoldingRegisters(Parameters.HoldingRegisters.Address.Value, Parameters.HoldingRegisters.Values.ToList());
                        break;
                    case ModbusCommand.WriteSingleHoldingRegister:
                        client.WriteSingleHoldingRegister(Parameters.HoldingRegister.Address.Value, Parameters.HoldingRegister.Value.Value);
                        break;
                    case ModbusCommand.ReadInputRegisters:
                        Parameters.InputRegisters.Values.SetValue(client.ReadInputRegisters(Parameters.InputRegisters.Address.Value, Parameters.InputRegisters.Count.Value));
                        break;
                }
            }
            finally
            {
                client?.Dispose();
                serialPort?.Close();
            }           
        }
    }
}
using System.IO.Ports;

using PL.Tree;
using PL.Tree.WinForms;

namespace ModbusClient
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly Bindings _bindings;

        public Form()
        {
            _bindings = new Bindings(LoseFocus);
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoseFocus();
            foreach (Control c in GetAllControls(this))
            {
                if (c is Panel || c is GroupBox)
                    c.Click += LoseFocus;
            }

            _bindings.Add(Parameters.Interface, comboBoxInterface);
            _bindings.Add(Parameters.Interface, this, (s, e) =>
            {
                flowLayoutPanelSerialSettings.Visible = Parameters.Interface.Value == PL.Modbus.Interface.Serial;
                flowLayoutPanelNetworkSettings.Visible = Parameters.Interface.Value == PL.Modbus.Interface.Network;
            });

            _bindings.Add(Parameters.Timeout, textBoxTimeout);
            _bindings.Add(Parameters.Hex, checkBoxHex);
            _bindings[^1].NodeValueChanged += (s, e) =>
            {
                checkBoxHex.Text = Parameters.Hex.Value ? "HEX" : "DEC";
                Parameters.Coils.Address.OnValueChanged();
                Parameters.Coils.Count.OnValueChanged();
                Parameters.Coil.Address.OnValueChanged();
                Parameters.DiscreteInputs.Address.OnValueChanged();
                Parameters.DiscreteInputs.Count.OnValueChanged();
                Parameters.HoldingRegisters.Address.OnValueChanged();
                Parameters.HoldingRegisters.Count.OnValueChanged();
                Parameters.HoldingRegisters.Values.OnValueChanged();
                Parameters.HoldingRegister.Address.OnValueChanged();
                Parameters.HoldingRegister.Value.OnValueChanged();
                Parameters.InputRegisters.Address.OnValueChanged();
                Parameters.InputRegisters.Count.OnValueChanged();
                Parameters.InputRegisters.Values.OnValueChanged();
            };

            _bindings.Add(Parameters.SerialSettings.PortName, comboBoxSerialSettingsPortName);
            comboBoxSerialSettingsPortName.DropDown += (s, e) =>
            {
                comboBoxSerialSettingsPortName.Items.Clear();
                comboBoxSerialSettingsPortName.Items.AddRange(SerialPort.GetPortNames());
            };
            _bindings.Add(Parameters.SerialSettings.Protocol, comboBoxSerialSettingsProtocol);
            _bindings.Add(Parameters.SerialSettings.StationAddress, textBoxSerialSettingsStationAddress);
            _bindings.Add(Parameters.SerialSettings.BaudRate, textBoxSerialSettingsBaudRate);
            _bindings.Add(Parameters.SerialSettings.DataBits, textBoxSerialSettingsDataBits);
            _bindings.Add(Parameters.SerialSettings.Parity, comboBoxSerialSettingsParity);
            _bindings.Add(Parameters.SerialSettings.StopBits, comboBoxSerialSettingsStopBits);
            _bindings.Add(Parameters.SerialSettings.Handshake, comboBoxSerialSettingsHandshake);

            _bindings.Add(Parameters.NetworkSettings.IpAddress, textBoxNetworkSettingsIpAddress);
            _bindings.Add(Parameters.NetworkSettings.Port, textBoxNetworkSettingsPort);
            _bindings.Add(Parameters.NetworkSettings.StationAddress, textBoxNetworkSettingsStationAddress);

            _bindings.Add(Parameters.Coils.Address, textBoxCoilsAddress).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.Coils.Count, textBoxCoilsCount).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.Coils.Values, dataGridViewCoilsValues, new CastConverter<bool, bool>());
            buttonCoilsRead.Click += (s, e) => Try (() => Program.ExecuteModbusCommand(ModbusCommand.ReadCoils));
            buttonCoilsWrite.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.WriteMultipleCoils));

            _bindings.Add(Parameters.Coil.Address, textBoxCoilAddress).Converter = new DecimalOrHexConverter(); ;
            _bindings.Add(Parameters.Coil.Value, checkBoxCoilValue);
            buttonCoilWrite.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.WriteSingleCoil));

            _bindings.Add(Parameters.DiscreteInputs.Address, textBoxDiscreteInputsAddress).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.DiscreteInputs.Count, textBoxDiscreteInputsCount).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.DiscreteInputs.Values, dataGridViewDiscreteInputsValues, new CastConverter<bool, bool>());
            buttonDiscreteInputsRead.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.ReadDiscreteInputs));

            _bindings.Add(Parameters.HoldingRegisters.Address, textBoxHoldingRegistersAddress).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.HoldingRegisters.Count, textBoxHoldingRegistersCount).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.HoldingRegisters.Values, dataGridViewHoldingRegistersValues, new DecimalOrHexConverter());
            buttonHoldingRegistersRead.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.ReadHoldingRegisters));
            buttonHoldingRegistersWrite.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.WriteMultipleHoldingRegisters));

            _bindings.Add(Parameters.HoldingRegister.Address, textBoxHoldingRegisterAddress).Converter = new DecimalOrHexConverter(); ;
            _bindings.Add(Parameters.HoldingRegister.Value, textBoxHoldingRegisterValue).Converter = new DecimalOrHexConverter(); ;
            buttonHoldingRegisterWrite.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.WriteSingleHoldingRegister));

            _bindings.Add(Parameters.InputRegisters.Address, textBoxInputRegistersAddress).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.InputRegisters.Count, textBoxInputRegistersCount).Converter = new DecimalOrHexConverter();
            _bindings.Add(Parameters.InputRegisters.Values, dataGridViewInputRegistersValues, new DecimalOrHexConverter());
            buttonInputRegistersRead.Click += (s, e) => Try(() => Program.ExecuteModbusCommand(ModbusCommand.ReadInputRegisters));

            _bindings.ControlValueChangedException += (s, e) => ShowError(e.Exception);
            _bindings.OnNodeValueChange();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e) => _bindings.Dispose();

        private void LoseFocus() => dummy.Select();

        private void LoseFocus(object? sender, EventArgs e) => LoseFocus();

        private void ShowError(Exception exception) => MessageBox.Show(this, exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private List<Control> GetAllControls(Control baseControl)
        {
            List<Control> controls = new();
            foreach (Control c in baseControl.Controls)
            {
                controls.Add(c);
                if (c.HasChildren)
                    controls.AddRange(GetAllControls(c));
            }
            return controls;
        }

        private void Try(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                ShowError(e);
            }
        }
    }

    internal class DecimalOrHexConverter : PL.Tree.Converter<ushort, string>
    {
        public override string ConvertSourceToTarget(ushort source) => Parameters.Hex.Value ? source.ToString("X") : source.ToString();

        public override ushort ConvertTargetToSource(string target) => Parameters.Hex.Value ? Convert.ToUInt16(target, 16) : ushort.Parse(target);
    }
}
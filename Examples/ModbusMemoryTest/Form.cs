using System.IO.Ports;

using PL.Tree;
using PL.Tree.WinForms;

namespace ModbusMemoryTest
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

            _bindings.Add(Parameters.NumberOfCoils, textBoxNumberOfCoils);
            _bindings.Add(Parameters.NumberOfHoldingRegisters, textBoxNumberOfHoldingRegisters);
            _bindings.Add(Parameters.NumberOfIterations, textBoxNumberOfIterations);
            _bindings.Add(Parameters.Start, checkBoxStart);
            _bindings[^1].NodeValueChanged += (s, e) => checkBoxStart.Text = Parameters.Start.Value ? "Stop" : "Start";
            _bindings.Add(Parameters.Start, this, (s, e) =>
            {
                flowLayoutPanelGeneralSettings.Enabled = !Parameters.Start.Value;
                flowLayoutPanelSerialSettings.Enabled = !Parameters.Start.Value;
                flowLayoutPanelNetworkSettings.Enabled = !Parameters.Start.Value;
                textBoxNumberOfCoils.Enabled = !Parameters.Start.Value;
                textBoxNumberOfHoldingRegisters.Enabled = !Parameters.Start.Value;
                textBoxNumberOfIterations.Enabled = !Parameters.Start.Value;
            });

            _bindings.Add(Parameters.Command, textBoxCommand);
            _bindings.Add(Parameters.Progress, progressBarProgress);

            _bindings.ControlValueChangedException += (s, e) => ShowError(e.Exception);
            _bindings.OnNodeValueChange();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs eventArgs)
        {
            if (!Parameters.Exit.Value)
            {
                Parameters.Exit.Value = true;
                eventArgs.Cancel = true;
            }
            else
            {
                _bindings.Dispose();
            }
        }

        private void LoseFocus() => dummy.Select();

        private void LoseFocus(object? sender, EventArgs e) => LoseFocus();

        internal void ShowError(Exception exception) => MessageBox.Show(this, exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
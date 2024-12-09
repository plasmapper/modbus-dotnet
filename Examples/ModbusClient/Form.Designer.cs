namespace ModbusClient
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            comboBoxInterface = new System.Windows.Forms.ComboBox();
            flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            label25 = new System.Windows.Forms.Label();
            textBoxConnectTimeout = new System.Windows.Forms.TextBox();
            flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            textBoxReadTimeout = new System.Windows.Forms.TextBox();
            checkBoxHex = new System.Windows.Forms.CheckBox();
            flowLayoutPanelSerialSettings = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            comboBoxSerialSettingsPortName = new System.Windows.Forms.ComboBox();
            flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            label7 = new System.Windows.Forms.Label();
            comboBoxSerialSettingsProtocol1 = new System.Windows.Forms.ComboBox();
            flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            textBoxSerialSettingsStationAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            textBoxSerialSettingsBaudRate = new System.Windows.Forms.TextBox();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            textBoxSerialSettingsDataBits = new System.Windows.Forms.TextBox();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            label8 = new System.Windows.Forms.Label();
            comboBoxSerialSettingsParity = new System.Windows.Forms.ComboBox();
            flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            label9 = new System.Windows.Forms.Label();
            comboBoxSerialSettingsStopBits = new System.Windows.Forms.ComboBox();
            flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            label10 = new System.Windows.Forms.Label();
            comboBoxSerialSettingsHandshake = new System.Windows.Forms.ComboBox();
            flowLayoutPanelNetworkSettings = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            label13 = new System.Windows.Forms.Label();
            textBoxNetworkSettingsIpAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            label14 = new System.Windows.Forms.Label();
            textBoxNetworkSettingsPort = new System.Windows.Forms.TextBox();
            flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            label26 = new System.Windows.Forms.Label();
            comboBoxSerialSettingsProtocol2 = new System.Windows.Forms.ComboBox();
            flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            label15 = new System.Windows.Forms.Label();
            textBoxNetworkSettingsStationAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel22 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel23 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel24 = new System.Windows.Forms.FlowLayoutPanel();
            label17 = new System.Windows.Forms.Label();
            textBoxCoilsAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel25 = new System.Windows.Forms.FlowLayoutPanel();
            label18 = new System.Windows.Forms.Label();
            textBoxCoilsCount = new System.Windows.Forms.TextBox();
            buttonCoilsRead = new System.Windows.Forms.Button();
            buttonCoilsWrite = new System.Windows.Forms.Button();
            dataGridViewCoilsValues = new System.Windows.Forms.DataGridView();
            columnCoils = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel20 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel21 = new System.Windows.Forms.FlowLayoutPanel();
            label11 = new System.Windows.Forms.Label();
            textBoxCoilAddress = new System.Windows.Forms.TextBox();
            checkBoxCoilValue = new System.Windows.Forms.CheckBox();
            buttonCoilWrite = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel26 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel27 = new System.Windows.Forms.FlowLayoutPanel();
            label12 = new System.Windows.Forms.Label();
            textBoxDiscreteInputsAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel28 = new System.Windows.Forms.FlowLayoutPanel();
            label16 = new System.Windows.Forms.Label();
            textBoxDiscreteInputsCount = new System.Windows.Forms.TextBox();
            buttonDiscreteInputsRead = new System.Windows.Forms.Button();
            dataGridViewDiscreteInputsValues = new System.Windows.Forms.DataGridView();
            columnDiscreteInputs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            groupBox4 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel29 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel30 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel31 = new System.Windows.Forms.FlowLayoutPanel();
            label19 = new System.Windows.Forms.Label();
            textBoxHoldingRegistersAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel32 = new System.Windows.Forms.FlowLayoutPanel();
            label20 = new System.Windows.Forms.Label();
            textBoxHoldingRegistersCount = new System.Windows.Forms.TextBox();
            buttonHoldingRegistersRead = new System.Windows.Forms.Button();
            buttonHoldingRegistersWrite = new System.Windows.Forms.Button();
            dataGridViewHoldingRegistersValues = new System.Windows.Forms.DataGridView();
            columnHoldingRegisters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox5 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel33 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel34 = new System.Windows.Forms.FlowLayoutPanel();
            label21 = new System.Windows.Forms.Label();
            textBoxHoldingRegisterAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel39 = new System.Windows.Forms.FlowLayoutPanel();
            label24 = new System.Windows.Forms.Label();
            textBoxHoldingRegisterValue = new System.Windows.Forms.TextBox();
            buttonHoldingRegisterWrite = new System.Windows.Forms.Button();
            groupBox6 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel35 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel36 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel37 = new System.Windows.Forms.FlowLayoutPanel();
            label22 = new System.Windows.Forms.Label();
            textBoxInputRegistersAddress = new System.Windows.Forms.TextBox();
            flowLayoutPanel38 = new System.Windows.Forms.FlowLayoutPanel();
            label23 = new System.Windows.Forms.Label();
            textBoxInputRegistersCount = new System.Windows.Forms.TextBox();
            buttonInputRegistersRead = new System.Windows.Forms.Button();
            dataGridViewInputRegistersValues = new System.Windows.Forms.DataGridView();
            columnInputRegisters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dummy = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanelSerialSettings.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            flowLayoutPanel13.SuspendLayout();
            flowLayoutPanelNetworkSettings.SuspendLayout();
            flowLayoutPanel17.SuspendLayout();
            flowLayoutPanel18.SuspendLayout();
            flowLayoutPanel14.SuspendLayout();
            flowLayoutPanel19.SuspendLayout();
            flowLayoutPanel15.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel22.SuspendLayout();
            flowLayoutPanel23.SuspendLayout();
            flowLayoutPanel24.SuspendLayout();
            flowLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoilsValues).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel20.SuspendLayout();
            flowLayoutPanel21.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel16.SuspendLayout();
            flowLayoutPanel26.SuspendLayout();
            flowLayoutPanel27.SuspendLayout();
            flowLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscreteInputsValues).BeginInit();
            groupBox4.SuspendLayout();
            flowLayoutPanel29.SuspendLayout();
            flowLayoutPanel30.SuspendLayout();
            flowLayoutPanel31.SuspendLayout();
            flowLayoutPanel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoldingRegistersValues).BeginInit();
            groupBox5.SuspendLayout();
            flowLayoutPanel33.SuspendLayout();
            flowLayoutPanel34.SuspendLayout();
            flowLayoutPanel39.SuspendLayout();
            groupBox6.SuspendLayout();
            flowLayoutPanel35.SuspendLayout();
            flowLayoutPanel36.SuspendLayout();
            flowLayoutPanel37.SuspendLayout();
            flowLayoutPanel38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputRegistersValues).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelSerialSettings);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelNetworkSettings);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel15);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(948, 473);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel5.Controls.Add(checkBoxHex);
            flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new System.Drawing.Size(441, 50);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.Controls.Add(label3);
            flowLayoutPanel6.Controls.Add(comboBoxInterface);
            flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel6.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Interface";
            // 
            // comboBoxInterface
            // 
            comboBoxInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxInterface.FormattingEnabled = true;
            comboBoxInterface.Items.AddRange(new object[] { "Serial", "Network" });
            comboBoxInterface.Location = new System.Drawing.Point(3, 18);
            comboBoxInterface.Name = "comboBoxInterface";
            comboBoxInterface.Size = new System.Drawing.Size(90, 23);
            comboBoxInterface.TabIndex = 4;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel8.Controls.Add(label25);
            flowLayoutPanel8.Controls.Add(textBoxConnectTimeout);
            flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel8.Location = new System.Drawing.Point(105, 3);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new System.Drawing.Size(125, 44);
            flowLayoutPanel8.TabIndex = 6;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(3, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(119, 15);
            label25.TabIndex = 0;
            label25.Text = "Connect timeout, ms";
            // 
            // textBoxConnectTimeout
            // 
            textBoxConnectTimeout.Location = new System.Drawing.Point(3, 18);
            textBoxConnectTimeout.Name = "textBoxConnectTimeout";
            textBoxConnectTimeout.Size = new System.Drawing.Size(90, 23);
            textBoxConnectTimeout.TabIndex = 3;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.Controls.Add(label4);
            flowLayoutPanel7.Controls.Add(textBoxReadTimeout);
            flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel7.Location = new System.Drawing.Point(236, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new System.Drawing.Size(106, 44);
            flowLayoutPanel7.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 15);
            label4.TabIndex = 0;
            label4.Text = "Read timeout, ms";
            // 
            // textBoxReadTimeout
            // 
            textBoxReadTimeout.Location = new System.Drawing.Point(3, 18);
            textBoxReadTimeout.Name = "textBoxReadTimeout";
            textBoxReadTimeout.Size = new System.Drawing.Size(90, 23);
            textBoxReadTimeout.TabIndex = 3;
            // 
            // checkBoxHex
            // 
            checkBoxHex.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxHex.Appearance = System.Windows.Forms.Appearance.Button;
            checkBoxHex.Location = new System.Drawing.Point(348, 22);
            checkBoxHex.Name = "checkBoxHex";
            checkBoxHex.Size = new System.Drawing.Size(90, 25);
            checkBoxHex.TabIndex = 5;
            checkBoxHex.Text = "checkBox1";
            checkBoxHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxHex.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSerialSettings
            // 
            flowLayoutPanelSerialSettings.AutoSize = true;
            flowLayoutPanelSerialSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel9);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel11);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel10);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel2);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel3);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel4);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel12);
            flowLayoutPanelSerialSettings.Controls.Add(flowLayoutPanel13);
            flowLayoutPanelSerialSettings.Location = new System.Drawing.Point(3, 59);
            flowLayoutPanelSerialSettings.Name = "flowLayoutPanelSerialSettings";
            flowLayoutPanelSerialSettings.Size = new System.Drawing.Size(816, 50);
            flowLayoutPanelSerialSettings.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel9.Controls.Add(label5);
            flowLayoutPanel9.Controls.Add(comboBoxSerialSettingsPortName);
            flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel9.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(29, 15);
            label5.TabIndex = 0;
            label5.Text = "Port";
            // 
            // comboBoxSerialSettingsPortName
            // 
            comboBoxSerialSettingsPortName.FormattingEnabled = true;
            comboBoxSerialSettingsPortName.Location = new System.Drawing.Point(3, 18);
            comboBoxSerialSettingsPortName.Name = "comboBoxSerialSettingsPortName";
            comboBoxSerialSettingsPortName.Size = new System.Drawing.Size(90, 23);
            comboBoxSerialSettingsPortName.TabIndex = 3;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.AutoSize = true;
            flowLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel11.Controls.Add(label7);
            flowLayoutPanel11.Controls.Add(comboBoxSerialSettingsProtocol1);
            flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel11.Location = new System.Drawing.Point(105, 3);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel11.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 15);
            label7.TabIndex = 0;
            label7.Text = "Protocol";
            // 
            // comboBoxSerialSettingsProtocol1
            // 
            comboBoxSerialSettingsProtocol1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSerialSettingsProtocol1.FormattingEnabled = true;
            comboBoxSerialSettingsProtocol1.Items.AddRange(new object[] { "RTU", "ASCII", "TCP" });
            comboBoxSerialSettingsProtocol1.Location = new System.Drawing.Point(3, 18);
            comboBoxSerialSettingsProtocol1.Name = "comboBoxSerialSettingsProtocol1";
            comboBoxSerialSettingsProtocol1.Size = new System.Drawing.Size(90, 23);
            comboBoxSerialSettingsProtocol1.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel10.Controls.Add(label6);
            flowLayoutPanel10.Controls.Add(textBoxSerialSettingsStationAddress);
            flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel10.Location = new System.Drawing.Point(207, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel10.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "Station address";
            // 
            // textBoxSerialSettingsStationAddress
            // 
            textBoxSerialSettingsStationAddress.Location = new System.Drawing.Point(3, 18);
            textBoxSerialSettingsStationAddress.Name = "textBoxSerialSettingsStationAddress";
            textBoxSerialSettingsStationAddress.Size = new System.Drawing.Size(90, 23);
            textBoxSerialSettingsStationAddress.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(textBoxSerialSettingsBaudRate);
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(309, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Baud rate";
            // 
            // textBoxSerialSettingsBaudRate
            // 
            textBoxSerialSettingsBaudRate.Location = new System.Drawing.Point(3, 18);
            textBoxSerialSettingsBaudRate.Name = "textBoxSerialSettingsBaudRate";
            textBoxSerialSettingsBaudRate.Size = new System.Drawing.Size(90, 23);
            textBoxSerialSettingsBaudRate.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(textBoxSerialSettingsDataBits);
            flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel3.Location = new System.Drawing.Point(411, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Data bits";
            // 
            // textBoxSerialSettingsDataBits
            // 
            textBoxSerialSettingsDataBits.Location = new System.Drawing.Point(3, 18);
            textBoxSerialSettingsDataBits.Name = "textBoxSerialSettingsDataBits";
            textBoxSerialSettingsDataBits.Size = new System.Drawing.Size(90, 23);
            textBoxSerialSettingsDataBits.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Controls.Add(comboBoxSerialSettingsParity);
            flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel4.Location = new System.Drawing.Point(513, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(3, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(37, 15);
            label8.TabIndex = 0;
            label8.Text = "Parity";
            // 
            // comboBoxSerialSettingsParity
            // 
            comboBoxSerialSettingsParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSerialSettingsParity.FormattingEnabled = true;
            comboBoxSerialSettingsParity.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            comboBoxSerialSettingsParity.Location = new System.Drawing.Point(3, 18);
            comboBoxSerialSettingsParity.Name = "comboBoxSerialSettingsParity";
            comboBoxSerialSettingsParity.Size = new System.Drawing.Size(90, 23);
            comboBoxSerialSettingsParity.TabIndex = 3;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.AutoSize = true;
            flowLayoutPanel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel12.Controls.Add(label9);
            flowLayoutPanel12.Controls.Add(comboBoxSerialSettingsStopBits);
            flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel12.Location = new System.Drawing.Point(615, 3);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel12.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(53, 15);
            label9.TabIndex = 0;
            label9.Text = "Stop bits";
            // 
            // comboBoxSerialSettingsStopBits
            // 
            comboBoxSerialSettingsStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSerialSettingsStopBits.FormattingEnabled = true;
            comboBoxSerialSettingsStopBits.Items.AddRange(new object[] { "None", "1.0", "2.0", "1.5" });
            comboBoxSerialSettingsStopBits.Location = new System.Drawing.Point(3, 18);
            comboBoxSerialSettingsStopBits.Name = "comboBoxSerialSettingsStopBits";
            comboBoxSerialSettingsStopBits.Size = new System.Drawing.Size(90, 23);
            comboBoxSerialSettingsStopBits.TabIndex = 3;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.AutoSize = true;
            flowLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel13.Controls.Add(label10);
            flowLayoutPanel13.Controls.Add(comboBoxSerialSettingsHandshake);
            flowLayoutPanel13.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel13.Location = new System.Drawing.Point(717, 3);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel13.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(3, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(66, 15);
            label10.TabIndex = 0;
            label10.Text = "Handshake";
            // 
            // comboBoxSerialSettingsHandshake
            // 
            comboBoxSerialSettingsHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSerialSettingsHandshake.FormattingEnabled = true;
            comboBoxSerialSettingsHandshake.Items.AddRange(new object[] { "None", "XON/XOFF", "RTS", "RTS XON/XOFF" });
            comboBoxSerialSettingsHandshake.Location = new System.Drawing.Point(3, 18);
            comboBoxSerialSettingsHandshake.Name = "comboBoxSerialSettingsHandshake";
            comboBoxSerialSettingsHandshake.Size = new System.Drawing.Size(90, 23);
            comboBoxSerialSettingsHandshake.TabIndex = 3;
            // 
            // flowLayoutPanelNetworkSettings
            // 
            flowLayoutPanelNetworkSettings.AutoSize = true;
            flowLayoutPanelNetworkSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelNetworkSettings.Controls.Add(flowLayoutPanel17);
            flowLayoutPanelNetworkSettings.Controls.Add(flowLayoutPanel18);
            flowLayoutPanelNetworkSettings.Controls.Add(flowLayoutPanel14);
            flowLayoutPanelNetworkSettings.Controls.Add(flowLayoutPanel19);
            flowLayoutPanelNetworkSettings.Location = new System.Drawing.Point(3, 115);
            flowLayoutPanelNetworkSettings.Name = "flowLayoutPanelNetworkSettings";
            flowLayoutPanelNetworkSettings.Size = new System.Drawing.Size(408, 50);
            flowLayoutPanelNetworkSettings.TabIndex = 2;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.AutoSize = true;
            flowLayoutPanel17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel17.Controls.Add(label13);
            flowLayoutPanel17.Controls.Add(textBoxNetworkSettingsIpAddress);
            flowLayoutPanel17.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel17.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(3, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(60, 15);
            label13.TabIndex = 0;
            label13.Text = "IP address";
            // 
            // textBoxNetworkSettingsIpAddress
            // 
            textBoxNetworkSettingsIpAddress.Location = new System.Drawing.Point(3, 18);
            textBoxNetworkSettingsIpAddress.Name = "textBoxNetworkSettingsIpAddress";
            textBoxNetworkSettingsIpAddress.Size = new System.Drawing.Size(90, 23);
            textBoxNetworkSettingsIpAddress.TabIndex = 3;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.AutoSize = true;
            flowLayoutPanel18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel18.Controls.Add(label14);
            flowLayoutPanel18.Controls.Add(textBoxNetworkSettingsPort);
            flowLayoutPanel18.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel18.Location = new System.Drawing.Point(105, 3);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel18.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(3, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 15);
            label14.TabIndex = 0;
            label14.Text = "Port";
            // 
            // textBoxNetworkSettingsPort
            // 
            textBoxNetworkSettingsPort.Location = new System.Drawing.Point(3, 18);
            textBoxNetworkSettingsPort.Name = "textBoxNetworkSettingsPort";
            textBoxNetworkSettingsPort.Size = new System.Drawing.Size(90, 23);
            textBoxNetworkSettingsPort.TabIndex = 3;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.AutoSize = true;
            flowLayoutPanel14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel14.Controls.Add(label26);
            flowLayoutPanel14.Controls.Add(comboBoxSerialSettingsProtocol2);
            flowLayoutPanel14.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel14.Location = new System.Drawing.Point(207, 3);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel14.TabIndex = 8;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(3, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(52, 15);
            label26.TabIndex = 0;
            label26.Text = "Protocol";
            // 
            // comboBoxSerialSettingsProtocol2
            // 
            comboBoxSerialSettingsProtocol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSerialSettingsProtocol2.FormattingEnabled = true;
            comboBoxSerialSettingsProtocol2.Items.AddRange(new object[] { "RTU", "ASCII", "TCP" });
            comboBoxSerialSettingsProtocol2.Location = new System.Drawing.Point(3, 18);
            comboBoxSerialSettingsProtocol2.Name = "comboBoxSerialSettingsProtocol2";
            comboBoxSerialSettingsProtocol2.Size = new System.Drawing.Size(90, 23);
            comboBoxSerialSettingsProtocol2.TabIndex = 3;
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.AutoSize = true;
            flowLayoutPanel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel19.Controls.Add(label15);
            flowLayoutPanel19.Controls.Add(textBoxNetworkSettingsStationAddress);
            flowLayoutPanel19.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel19.Location = new System.Drawing.Point(309, 3);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel19.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(3, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(87, 15);
            label15.TabIndex = 0;
            label15.Text = "Station address";
            // 
            // textBoxNetworkSettingsStationAddress
            // 
            textBoxNetworkSettingsStationAddress.Location = new System.Drawing.Point(3, 18);
            textBoxNetworkSettingsStationAddress.Name = "textBoxNetworkSettingsStationAddress";
            textBoxNetworkSettingsStationAddress.Size = new System.Drawing.Size(90, 23);
            textBoxNetworkSettingsStationAddress.TabIndex = 3;
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.AutoSize = true;
            flowLayoutPanel15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel15.Controls.Add(groupBox1);
            flowLayoutPanel15.Controls.Add(groupBox2);
            flowLayoutPanel15.Controls.Add(groupBox3);
            flowLayoutPanel15.Controls.Add(groupBox4);
            flowLayoutPanel15.Controls.Add(groupBox5);
            flowLayoutPanel15.Controls.Add(groupBox6);
            flowLayoutPanel15.Location = new System.Drawing.Point(3, 171);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new System.Drawing.Size(942, 299);
            flowLayoutPanel15.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(flowLayoutPanel22);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(165, 293);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Coils";
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.AutoSize = true;
            flowLayoutPanel22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel22.Controls.Add(flowLayoutPanel23);
            flowLayoutPanel22.Controls.Add(dataGridViewCoilsValues);
            flowLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel22.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Size = new System.Drawing.Size(159, 271);
            flowLayoutPanel22.TabIndex = 0;
            // 
            // flowLayoutPanel23
            // 
            flowLayoutPanel23.AutoSize = true;
            flowLayoutPanel23.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel23.Controls.Add(flowLayoutPanel24);
            flowLayoutPanel23.Controls.Add(flowLayoutPanel25);
            flowLayoutPanel23.Controls.Add(buttonCoilsRead);
            flowLayoutPanel23.Controls.Add(buttonCoilsWrite);
            flowLayoutPanel23.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel23.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel23.Name = "flowLayoutPanel23";
            flowLayoutPanel23.Size = new System.Drawing.Size(102, 158);
            flowLayoutPanel23.TabIndex = 1;
            // 
            // flowLayoutPanel24
            // 
            flowLayoutPanel24.AutoSize = true;
            flowLayoutPanel24.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel24.Controls.Add(label17);
            flowLayoutPanel24.Controls.Add(textBoxCoilsAddress);
            flowLayoutPanel24.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel24.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel24.Name = "flowLayoutPanel24";
            flowLayoutPanel24.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel24.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(3, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(49, 15);
            label17.TabIndex = 0;
            label17.Text = "Address";
            // 
            // textBoxCoilsAddress
            // 
            textBoxCoilsAddress.Location = new System.Drawing.Point(3, 18);
            textBoxCoilsAddress.Name = "textBoxCoilsAddress";
            textBoxCoilsAddress.Size = new System.Drawing.Size(90, 23);
            textBoxCoilsAddress.TabIndex = 3;
            // 
            // flowLayoutPanel25
            // 
            flowLayoutPanel25.AutoSize = true;
            flowLayoutPanel25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel25.Controls.Add(label18);
            flowLayoutPanel25.Controls.Add(textBoxCoilsCount);
            flowLayoutPanel25.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel25.Location = new System.Drawing.Point(3, 53);
            flowLayoutPanel25.Name = "flowLayoutPanel25";
            flowLayoutPanel25.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel25.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(3, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(40, 15);
            label18.TabIndex = 0;
            label18.Text = "Count";
            // 
            // textBoxCoilsCount
            // 
            textBoxCoilsCount.Location = new System.Drawing.Point(3, 18);
            textBoxCoilsCount.Name = "textBoxCoilsCount";
            textBoxCoilsCount.Size = new System.Drawing.Size(90, 23);
            textBoxCoilsCount.TabIndex = 3;
            // 
            // buttonCoilsRead
            // 
            buttonCoilsRead.Location = new System.Drawing.Point(3, 103);
            buttonCoilsRead.Name = "buttonCoilsRead";
            buttonCoilsRead.Size = new System.Drawing.Size(90, 23);
            buttonCoilsRead.TabIndex = 4;
            buttonCoilsRead.Text = "Read";
            buttonCoilsRead.UseVisualStyleBackColor = true;
            // 
            // buttonCoilsWrite
            // 
            buttonCoilsWrite.Location = new System.Drawing.Point(3, 132);
            buttonCoilsWrite.Name = "buttonCoilsWrite";
            buttonCoilsWrite.Size = new System.Drawing.Size(90, 23);
            buttonCoilsWrite.TabIndex = 10;
            buttonCoilsWrite.Text = "Write";
            buttonCoilsWrite.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCoilsValues
            // 
            dataGridViewCoilsValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCoilsValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoilsValues.ColumnHeadersVisible = false;
            dataGridViewCoilsValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { columnCoils });
            dataGridViewCoilsValues.Location = new System.Drawing.Point(111, 3);
            dataGridViewCoilsValues.Name = "dataGridViewCoilsValues";
            dataGridViewCoilsValues.RowHeadersVisible = false;
            dataGridViewCoilsValues.RowTemplate.Height = 25;
            dataGridViewCoilsValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewCoilsValues.Size = new System.Drawing.Size(45, 265);
            dataGridViewCoilsValues.TabIndex = 0;
            // 
            // columnCoils
            // 
            columnCoils.HeaderText = "Column1";
            columnCoils.Name = "columnCoils";
            columnCoils.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            columnCoils.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            columnCoils.Width = 21;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(flowLayoutPanel20);
            groupBox2.Location = new System.Drawing.Point(174, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(108, 126);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coil";
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.AutoSize = true;
            flowLayoutPanel20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel20.Controls.Add(flowLayoutPanel21);
            flowLayoutPanel20.Controls.Add(checkBoxCoilValue);
            flowLayoutPanel20.Controls.Add(buttonCoilWrite);
            flowLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel20.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel20.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new System.Drawing.Size(102, 104);
            flowLayoutPanel20.TabIndex = 1;
            // 
            // flowLayoutPanel21
            // 
            flowLayoutPanel21.AutoSize = true;
            flowLayoutPanel21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel21.Controls.Add(label11);
            flowLayoutPanel21.Controls.Add(textBoxCoilAddress);
            flowLayoutPanel21.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel21.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel21.Name = "flowLayoutPanel21";
            flowLayoutPanel21.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel21.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(3, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(49, 15);
            label11.TabIndex = 0;
            label11.Text = "Address";
            // 
            // textBoxCoilAddress
            // 
            textBoxCoilAddress.Location = new System.Drawing.Point(3, 18);
            textBoxCoilAddress.Name = "textBoxCoilAddress";
            textBoxCoilAddress.Size = new System.Drawing.Size(90, 23);
            textBoxCoilAddress.TabIndex = 3;
            // 
            // checkBoxCoilValue
            // 
            checkBoxCoilValue.AutoSize = true;
            checkBoxCoilValue.Location = new System.Drawing.Point(3, 53);
            checkBoxCoilValue.Name = "checkBoxCoilValue";
            checkBoxCoilValue.Size = new System.Drawing.Size(54, 19);
            checkBoxCoilValue.TabIndex = 11;
            checkBoxCoilValue.Text = "Value";
            checkBoxCoilValue.UseVisualStyleBackColor = true;
            // 
            // buttonCoilWrite
            // 
            buttonCoilWrite.Location = new System.Drawing.Point(3, 78);
            buttonCoilWrite.Name = "buttonCoilWrite";
            buttonCoilWrite.Size = new System.Drawing.Size(90, 23);
            buttonCoilWrite.TabIndex = 10;
            buttonCoilWrite.Text = "Write";
            buttonCoilWrite.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(flowLayoutPanel16);
            groupBox3.Location = new System.Drawing.Point(288, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(165, 293);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discrete inputs";
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.AutoSize = true;
            flowLayoutPanel16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel16.Controls.Add(flowLayoutPanel26);
            flowLayoutPanel16.Controls.Add(dataGridViewDiscreteInputsValues);
            flowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel16.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Size = new System.Drawing.Size(159, 271);
            flowLayoutPanel16.TabIndex = 0;
            // 
            // flowLayoutPanel26
            // 
            flowLayoutPanel26.AutoSize = true;
            flowLayoutPanel26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel26.Controls.Add(flowLayoutPanel27);
            flowLayoutPanel26.Controls.Add(flowLayoutPanel28);
            flowLayoutPanel26.Controls.Add(buttonDiscreteInputsRead);
            flowLayoutPanel26.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel26.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel26.Name = "flowLayoutPanel26";
            flowLayoutPanel26.Size = new System.Drawing.Size(102, 129);
            flowLayoutPanel26.TabIndex = 1;
            // 
            // flowLayoutPanel27
            // 
            flowLayoutPanel27.AutoSize = true;
            flowLayoutPanel27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel27.Controls.Add(label12);
            flowLayoutPanel27.Controls.Add(textBoxDiscreteInputsAddress);
            flowLayoutPanel27.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel27.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel27.Name = "flowLayoutPanel27";
            flowLayoutPanel27.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel27.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(3, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(49, 15);
            label12.TabIndex = 0;
            label12.Text = "Address";
            // 
            // textBoxDiscreteInputsAddress
            // 
            textBoxDiscreteInputsAddress.Location = new System.Drawing.Point(3, 18);
            textBoxDiscreteInputsAddress.Name = "textBoxDiscreteInputsAddress";
            textBoxDiscreteInputsAddress.Size = new System.Drawing.Size(90, 23);
            textBoxDiscreteInputsAddress.TabIndex = 3;
            // 
            // flowLayoutPanel28
            // 
            flowLayoutPanel28.AutoSize = true;
            flowLayoutPanel28.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel28.Controls.Add(label16);
            flowLayoutPanel28.Controls.Add(textBoxDiscreteInputsCount);
            flowLayoutPanel28.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel28.Location = new System.Drawing.Point(3, 53);
            flowLayoutPanel28.Name = "flowLayoutPanel28";
            flowLayoutPanel28.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel28.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(3, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(40, 15);
            label16.TabIndex = 0;
            label16.Text = "Count";
            // 
            // textBoxDiscreteInputsCount
            // 
            textBoxDiscreteInputsCount.Location = new System.Drawing.Point(3, 18);
            textBoxDiscreteInputsCount.Name = "textBoxDiscreteInputsCount";
            textBoxDiscreteInputsCount.Size = new System.Drawing.Size(90, 23);
            textBoxDiscreteInputsCount.TabIndex = 3;
            // 
            // buttonDiscreteInputsRead
            // 
            buttonDiscreteInputsRead.Location = new System.Drawing.Point(3, 103);
            buttonDiscreteInputsRead.Name = "buttonDiscreteInputsRead";
            buttonDiscreteInputsRead.Size = new System.Drawing.Size(90, 23);
            buttonDiscreteInputsRead.TabIndex = 4;
            buttonDiscreteInputsRead.Text = "Read";
            buttonDiscreteInputsRead.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDiscreteInputsValues
            // 
            dataGridViewDiscreteInputsValues.AllowUserToAddRows = false;
            dataGridViewDiscreteInputsValues.AllowUserToDeleteRows = false;
            dataGridViewDiscreteInputsValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDiscreteInputsValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDiscreteInputsValues.ColumnHeadersVisible = false;
            dataGridViewDiscreteInputsValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { columnDiscreteInputs });
            dataGridViewDiscreteInputsValues.Location = new System.Drawing.Point(111, 3);
            dataGridViewDiscreteInputsValues.Name = "dataGridViewDiscreteInputsValues";
            dataGridViewDiscreteInputsValues.ReadOnly = true;
            dataGridViewDiscreteInputsValues.RowHeadersVisible = false;
            dataGridViewDiscreteInputsValues.RowTemplate.Height = 25;
            dataGridViewDiscreteInputsValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewDiscreteInputsValues.Size = new System.Drawing.Size(45, 265);
            dataGridViewDiscreteInputsValues.TabIndex = 0;
            // 
            // columnDiscreteInputs
            // 
            columnDiscreteInputs.HeaderText = "Column1";
            columnDiscreteInputs.Name = "columnDiscreteInputs";
            columnDiscreteInputs.ReadOnly = true;
            columnDiscreteInputs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            columnDiscreteInputs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            columnDiscreteInputs.Width = 5;
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(flowLayoutPanel29);
            groupBox4.Location = new System.Drawing.Point(459, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(180, 293);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Holding registers";
            // 
            // flowLayoutPanel29
            // 
            flowLayoutPanel29.AutoSize = true;
            flowLayoutPanel29.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel29.Controls.Add(flowLayoutPanel30);
            flowLayoutPanel29.Controls.Add(dataGridViewHoldingRegistersValues);
            flowLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel29.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel29.Name = "flowLayoutPanel29";
            flowLayoutPanel29.Size = new System.Drawing.Size(174, 271);
            flowLayoutPanel29.TabIndex = 0;
            // 
            // flowLayoutPanel30
            // 
            flowLayoutPanel30.AutoSize = true;
            flowLayoutPanel30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel30.Controls.Add(flowLayoutPanel31);
            flowLayoutPanel30.Controls.Add(flowLayoutPanel32);
            flowLayoutPanel30.Controls.Add(buttonHoldingRegistersRead);
            flowLayoutPanel30.Controls.Add(buttonHoldingRegistersWrite);
            flowLayoutPanel30.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel30.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel30.Name = "flowLayoutPanel30";
            flowLayoutPanel30.Size = new System.Drawing.Size(102, 158);
            flowLayoutPanel30.TabIndex = 1;
            // 
            // flowLayoutPanel31
            // 
            flowLayoutPanel31.AutoSize = true;
            flowLayoutPanel31.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel31.Controls.Add(label19);
            flowLayoutPanel31.Controls.Add(textBoxHoldingRegistersAddress);
            flowLayoutPanel31.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel31.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel31.Name = "flowLayoutPanel31";
            flowLayoutPanel31.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel31.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(3, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(49, 15);
            label19.TabIndex = 0;
            label19.Text = "Address";
            // 
            // textBoxHoldingRegistersAddress
            // 
            textBoxHoldingRegistersAddress.Location = new System.Drawing.Point(3, 18);
            textBoxHoldingRegistersAddress.Name = "textBoxHoldingRegistersAddress";
            textBoxHoldingRegistersAddress.Size = new System.Drawing.Size(90, 23);
            textBoxHoldingRegistersAddress.TabIndex = 3;
            // 
            // flowLayoutPanel32
            // 
            flowLayoutPanel32.AutoSize = true;
            flowLayoutPanel32.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel32.Controls.Add(label20);
            flowLayoutPanel32.Controls.Add(textBoxHoldingRegistersCount);
            flowLayoutPanel32.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel32.Location = new System.Drawing.Point(3, 53);
            flowLayoutPanel32.Name = "flowLayoutPanel32";
            flowLayoutPanel32.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel32.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(3, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(40, 15);
            label20.TabIndex = 0;
            label20.Text = "Count";
            // 
            // textBoxHoldingRegistersCount
            // 
            textBoxHoldingRegistersCount.Location = new System.Drawing.Point(3, 18);
            textBoxHoldingRegistersCount.Name = "textBoxHoldingRegistersCount";
            textBoxHoldingRegistersCount.Size = new System.Drawing.Size(90, 23);
            textBoxHoldingRegistersCount.TabIndex = 3;
            // 
            // buttonHoldingRegistersRead
            // 
            buttonHoldingRegistersRead.Location = new System.Drawing.Point(3, 103);
            buttonHoldingRegistersRead.Name = "buttonHoldingRegistersRead";
            buttonHoldingRegistersRead.Size = new System.Drawing.Size(90, 23);
            buttonHoldingRegistersRead.TabIndex = 4;
            buttonHoldingRegistersRead.Text = "Read";
            buttonHoldingRegistersRead.UseVisualStyleBackColor = true;
            // 
            // buttonHoldingRegistersWrite
            // 
            buttonHoldingRegistersWrite.Location = new System.Drawing.Point(3, 132);
            buttonHoldingRegistersWrite.Name = "buttonHoldingRegistersWrite";
            buttonHoldingRegistersWrite.Size = new System.Drawing.Size(90, 23);
            buttonHoldingRegistersWrite.TabIndex = 10;
            buttonHoldingRegistersWrite.Text = "Write";
            buttonHoldingRegistersWrite.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHoldingRegistersValues
            // 
            dataGridViewHoldingRegistersValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHoldingRegistersValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoldingRegistersValues.ColumnHeadersVisible = false;
            dataGridViewHoldingRegistersValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { columnHoldingRegisters });
            dataGridViewHoldingRegistersValues.Location = new System.Drawing.Point(111, 3);
            dataGridViewHoldingRegistersValues.Name = "dataGridViewHoldingRegistersValues";
            dataGridViewHoldingRegistersValues.RowHeadersVisible = false;
            dataGridViewHoldingRegistersValues.RowTemplate.Height = 25;
            dataGridViewHoldingRegistersValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewHoldingRegistersValues.Size = new System.Drawing.Size(60, 265);
            dataGridViewHoldingRegistersValues.TabIndex = 0;
            // 
            // columnHoldingRegisters
            // 
            columnHoldingRegisters.HeaderText = "Column1";
            columnHoldingRegisters.Name = "columnHoldingRegisters";
            columnHoldingRegisters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            columnHoldingRegisters.Width = 21;
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox5.Controls.Add(flowLayoutPanel33);
            groupBox5.Location = new System.Drawing.Point(645, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(108, 151);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Holding register";
            // 
            // flowLayoutPanel33
            // 
            flowLayoutPanel33.AutoSize = true;
            flowLayoutPanel33.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel33.Controls.Add(flowLayoutPanel34);
            flowLayoutPanel33.Controls.Add(flowLayoutPanel39);
            flowLayoutPanel33.Controls.Add(buttonHoldingRegisterWrite);
            flowLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel33.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel33.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel33.Name = "flowLayoutPanel33";
            flowLayoutPanel33.Size = new System.Drawing.Size(102, 129);
            flowLayoutPanel33.TabIndex = 1;
            // 
            // flowLayoutPanel34
            // 
            flowLayoutPanel34.AutoSize = true;
            flowLayoutPanel34.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel34.Controls.Add(label21);
            flowLayoutPanel34.Controls.Add(textBoxHoldingRegisterAddress);
            flowLayoutPanel34.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel34.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel34.Name = "flowLayoutPanel34";
            flowLayoutPanel34.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel34.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(3, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(49, 15);
            label21.TabIndex = 0;
            label21.Text = "Address";
            // 
            // textBoxHoldingRegisterAddress
            // 
            textBoxHoldingRegisterAddress.Location = new System.Drawing.Point(3, 18);
            textBoxHoldingRegisterAddress.Name = "textBoxHoldingRegisterAddress";
            textBoxHoldingRegisterAddress.Size = new System.Drawing.Size(90, 23);
            textBoxHoldingRegisterAddress.TabIndex = 3;
            // 
            // flowLayoutPanel39
            // 
            flowLayoutPanel39.AutoSize = true;
            flowLayoutPanel39.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel39.Controls.Add(label24);
            flowLayoutPanel39.Controls.Add(textBoxHoldingRegisterValue);
            flowLayoutPanel39.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel39.Location = new System.Drawing.Point(3, 53);
            flowLayoutPanel39.Name = "flowLayoutPanel39";
            flowLayoutPanel39.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel39.TabIndex = 12;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(3, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(35, 15);
            label24.TabIndex = 0;
            label24.Text = "Value";
            // 
            // textBoxHoldingRegisterValue
            // 
            textBoxHoldingRegisterValue.Location = new System.Drawing.Point(3, 18);
            textBoxHoldingRegisterValue.Name = "textBoxHoldingRegisterValue";
            textBoxHoldingRegisterValue.Size = new System.Drawing.Size(90, 23);
            textBoxHoldingRegisterValue.TabIndex = 3;
            // 
            // buttonHoldingRegisterWrite
            // 
            buttonHoldingRegisterWrite.Location = new System.Drawing.Point(3, 103);
            buttonHoldingRegisterWrite.Name = "buttonHoldingRegisterWrite";
            buttonHoldingRegisterWrite.Size = new System.Drawing.Size(90, 23);
            buttonHoldingRegisterWrite.TabIndex = 10;
            buttonHoldingRegisterWrite.Text = "Write";
            buttonHoldingRegisterWrite.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.AutoSize = true;
            groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox6.Controls.Add(flowLayoutPanel35);
            groupBox6.Location = new System.Drawing.Point(759, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(180, 293);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Input registers";
            // 
            // flowLayoutPanel35
            // 
            flowLayoutPanel35.AutoSize = true;
            flowLayoutPanel35.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel35.Controls.Add(flowLayoutPanel36);
            flowLayoutPanel35.Controls.Add(dataGridViewInputRegistersValues);
            flowLayoutPanel35.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel35.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel35.Name = "flowLayoutPanel35";
            flowLayoutPanel35.Size = new System.Drawing.Size(174, 271);
            flowLayoutPanel35.TabIndex = 0;
            // 
            // flowLayoutPanel36
            // 
            flowLayoutPanel36.AutoSize = true;
            flowLayoutPanel36.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel36.Controls.Add(flowLayoutPanel37);
            flowLayoutPanel36.Controls.Add(flowLayoutPanel38);
            flowLayoutPanel36.Controls.Add(buttonInputRegistersRead);
            flowLayoutPanel36.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel36.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel36.Name = "flowLayoutPanel36";
            flowLayoutPanel36.Size = new System.Drawing.Size(102, 129);
            flowLayoutPanel36.TabIndex = 1;
            // 
            // flowLayoutPanel37
            // 
            flowLayoutPanel37.AutoSize = true;
            flowLayoutPanel37.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel37.Controls.Add(label22);
            flowLayoutPanel37.Controls.Add(textBoxInputRegistersAddress);
            flowLayoutPanel37.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel37.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel37.Name = "flowLayoutPanel37";
            flowLayoutPanel37.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel37.TabIndex = 7;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(3, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(49, 15);
            label22.TabIndex = 0;
            label22.Text = "Address";
            // 
            // textBoxInputRegistersAddress
            // 
            textBoxInputRegistersAddress.Location = new System.Drawing.Point(3, 18);
            textBoxInputRegistersAddress.Name = "textBoxInputRegistersAddress";
            textBoxInputRegistersAddress.Size = new System.Drawing.Size(90, 23);
            textBoxInputRegistersAddress.TabIndex = 3;
            // 
            // flowLayoutPanel38
            // 
            flowLayoutPanel38.AutoSize = true;
            flowLayoutPanel38.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel38.Controls.Add(label23);
            flowLayoutPanel38.Controls.Add(textBoxInputRegistersCount);
            flowLayoutPanel38.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel38.Location = new System.Drawing.Point(3, 53);
            flowLayoutPanel38.Name = "flowLayoutPanel38";
            flowLayoutPanel38.Size = new System.Drawing.Size(96, 44);
            flowLayoutPanel38.TabIndex = 8;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(3, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(40, 15);
            label23.TabIndex = 0;
            label23.Text = "Count";
            // 
            // textBoxInputRegistersCount
            // 
            textBoxInputRegistersCount.Location = new System.Drawing.Point(3, 18);
            textBoxInputRegistersCount.Name = "textBoxInputRegistersCount";
            textBoxInputRegistersCount.Size = new System.Drawing.Size(90, 23);
            textBoxInputRegistersCount.TabIndex = 3;
            // 
            // buttonInputRegistersRead
            // 
            buttonInputRegistersRead.Location = new System.Drawing.Point(3, 103);
            buttonInputRegistersRead.Name = "buttonInputRegistersRead";
            buttonInputRegistersRead.Size = new System.Drawing.Size(90, 23);
            buttonInputRegistersRead.TabIndex = 4;
            buttonInputRegistersRead.Text = "Read";
            buttonInputRegistersRead.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInputRegistersValues
            // 
            dataGridViewInputRegistersValues.AllowUserToAddRows = false;
            dataGridViewInputRegistersValues.AllowUserToDeleteRows = false;
            dataGridViewInputRegistersValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInputRegistersValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInputRegistersValues.ColumnHeadersVisible = false;
            dataGridViewInputRegistersValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { columnInputRegisters });
            dataGridViewInputRegistersValues.Location = new System.Drawing.Point(111, 3);
            dataGridViewInputRegistersValues.Name = "dataGridViewInputRegistersValues";
            dataGridViewInputRegistersValues.ReadOnly = true;
            dataGridViewInputRegistersValues.RowHeadersVisible = false;
            dataGridViewInputRegistersValues.RowTemplate.Height = 25;
            dataGridViewInputRegistersValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewInputRegistersValues.Size = new System.Drawing.Size(60, 265);
            dataGridViewInputRegistersValues.TabIndex = 0;
            // 
            // columnInputRegisters
            // 
            columnInputRegisters.HeaderText = "Column1";
            columnInputRegisters.Name = "columnInputRegisters";
            columnInputRegisters.ReadOnly = true;
            columnInputRegisters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            columnInputRegisters.Width = 5;
            // 
            // dummy
            // 
            dummy.Location = new System.Drawing.Point(0, 0);
            dummy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dummy.Name = "dummy";
            dummy.Size = new System.Drawing.Size(0, 0);
            dummy.TabIndex = 1;
            dummy.Text = "button1";
            dummy.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(984, 504);
            Controls.Add(dummy);
            Controls.Add(flowLayoutPanel1);
            Name = "Form";
            Text = "Modbus Client";
            FormClosing += this.Form_FormClosing;
            Load += this.Form_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanelSerialSettings.ResumeLayout(false);
            flowLayoutPanelSerialSettings.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel12.ResumeLayout(false);
            flowLayoutPanel12.PerformLayout();
            flowLayoutPanel13.ResumeLayout(false);
            flowLayoutPanel13.PerformLayout();
            flowLayoutPanelNetworkSettings.ResumeLayout(false);
            flowLayoutPanelNetworkSettings.PerformLayout();
            flowLayoutPanel17.ResumeLayout(false);
            flowLayoutPanel17.PerformLayout();
            flowLayoutPanel18.ResumeLayout(false);
            flowLayoutPanel18.PerformLayout();
            flowLayoutPanel14.ResumeLayout(false);
            flowLayoutPanel14.PerformLayout();
            flowLayoutPanel19.ResumeLayout(false);
            flowLayoutPanel19.PerformLayout();
            flowLayoutPanel15.ResumeLayout(false);
            flowLayoutPanel15.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel22.ResumeLayout(false);
            flowLayoutPanel22.PerformLayout();
            flowLayoutPanel23.ResumeLayout(false);
            flowLayoutPanel23.PerformLayout();
            flowLayoutPanel24.ResumeLayout(false);
            flowLayoutPanel24.PerformLayout();
            flowLayoutPanel25.ResumeLayout(false);
            flowLayoutPanel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoilsValues).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel20.ResumeLayout(false);
            flowLayoutPanel20.PerformLayout();
            flowLayoutPanel21.ResumeLayout(false);
            flowLayoutPanel21.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel16.ResumeLayout(false);
            flowLayoutPanel16.PerformLayout();
            flowLayoutPanel26.ResumeLayout(false);
            flowLayoutPanel26.PerformLayout();
            flowLayoutPanel27.ResumeLayout(false);
            flowLayoutPanel27.PerformLayout();
            flowLayoutPanel28.ResumeLayout(false);
            flowLayoutPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscreteInputsValues).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            flowLayoutPanel29.ResumeLayout(false);
            flowLayoutPanel29.PerformLayout();
            flowLayoutPanel30.ResumeLayout(false);
            flowLayoutPanel30.PerformLayout();
            flowLayoutPanel31.ResumeLayout(false);
            flowLayoutPanel31.PerformLayout();
            flowLayoutPanel32.ResumeLayout(false);
            flowLayoutPanel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoldingRegistersValues).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            flowLayoutPanel33.ResumeLayout(false);
            flowLayoutPanel33.PerformLayout();
            flowLayoutPanel34.ResumeLayout(false);
            flowLayoutPanel34.PerformLayout();
            flowLayoutPanel39.ResumeLayout(false);
            flowLayoutPanel39.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            flowLayoutPanel35.ResumeLayout(false);
            flowLayoutPanel35.PerformLayout();
            flowLayoutPanel36.ResumeLayout(false);
            flowLayoutPanel36.PerformLayout();
            flowLayoutPanel37.ResumeLayout(false);
            flowLayoutPanel37.PerformLayout();
            flowLayoutPanel38.ResumeLayout(false);
            flowLayoutPanel38.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputRegistersValues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label3;
        private ComboBox comboBoxInterface;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label4;
        private TextBox textBoxReadTimeout;
        private CheckBox checkBoxHex;
        private FlowLayoutPanel flowLayoutPanelSerialSettings;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label5;
        private ComboBox comboBoxSerialSettingsPortName;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label label7;
        private ComboBox comboBoxSerialSettingsProtocol1;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label6;
        private TextBox textBoxSerialSettingsStationAddress;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TextBox textBoxSerialSettingsBaudRate;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private TextBox textBoxSerialSettingsDataBits;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label8;
        private ComboBox comboBoxSerialSettingsParity;
        private FlowLayoutPanel flowLayoutPanel12;
        private Label label9;
        private ComboBox comboBoxSerialSettingsStopBits;
        private FlowLayoutPanel flowLayoutPanel13;
        private Label label10;
        private ComboBox comboBoxSerialSettingsHandshake;
        private FlowLayoutPanel flowLayoutPanelNetworkSettings;
        private FlowLayoutPanel flowLayoutPanel17;
        private Label label13;
        private TextBox textBoxNetworkSettingsIpAddress;
        private FlowLayoutPanel flowLayoutPanel18;
        private Label label14;
        private TextBox textBoxNetworkSettingsPort;
        private FlowLayoutPanel flowLayoutPanel19;
        private Label label15;
        private TextBox textBoxNetworkSettingsStationAddress;
        private FlowLayoutPanel flowLayoutPanel15;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel22;
        private DataGridView dataGridViewCoilsValues;
        private DataGridViewCheckBoxColumn columnCoils;
        private FlowLayoutPanel flowLayoutPanel23;
        private FlowLayoutPanel flowLayoutPanel24;
        private Label label17;
        private TextBox textBoxCoilsAddress;
        private FlowLayoutPanel flowLayoutPanel25;
        private Label label18;
        private TextBox textBoxCoilsCount;
        private Button buttonCoilsRead;
        private Button buttonCoilsWrite;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel20;
        private FlowLayoutPanel flowLayoutPanel21;
        private Label label11;
        private TextBox textBoxCoilAddress;
        private CheckBox checkBoxCoilValue;
        private Button buttonCoilWrite;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel16;
        private DataGridView dataGridViewDiscreteInputsValues;
        private DataGridViewCheckBoxColumn columnDiscreteInputs;
        private FlowLayoutPanel flowLayoutPanel26;
        private FlowLayoutPanel flowLayoutPanel27;
        private Label label12;
        private TextBox textBoxDiscreteInputsAddress;
        private FlowLayoutPanel flowLayoutPanel28;
        private Label label16;
        private TextBox textBoxDiscreteInputsCount;
        private Button buttonDiscreteInputsRead;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel29;
        private DataGridView dataGridViewHoldingRegistersValues;
        private DataGridViewTextBoxColumn columnHoldingRegisters;
        private FlowLayoutPanel flowLayoutPanel30;
        private FlowLayoutPanel flowLayoutPanel31;
        private Label label19;
        private TextBox textBoxHoldingRegistersAddress;
        private FlowLayoutPanel flowLayoutPanel32;
        private Label label20;
        private TextBox textBoxHoldingRegistersCount;
        private Button buttonHoldingRegistersRead;
        private Button buttonHoldingRegistersWrite;
        private GroupBox groupBox5;
        private FlowLayoutPanel flowLayoutPanel33;
        private FlowLayoutPanel flowLayoutPanel34;
        private Label label21;
        private TextBox textBoxHoldingRegisterAddress;
        private FlowLayoutPanel flowLayoutPanel39;
        private Label label24;
        private TextBox textBoxHoldingRegisterValue;
        private Button buttonHoldingRegisterWrite;
        private GroupBox groupBox6;
        private FlowLayoutPanel flowLayoutPanel35;
        private DataGridView dataGridViewInputRegistersValues;
        private FlowLayoutPanel flowLayoutPanel36;
        private FlowLayoutPanel flowLayoutPanel37;
        private Label label22;
        private TextBox textBoxInputRegistersAddress;
        private FlowLayoutPanel flowLayoutPanel38;
        private Label label23;
        private TextBox textBoxInputRegistersCount;
        private Button buttonInputRegistersRead;
        private Button dummy;
        private DataGridViewTextBoxColumn columnInputRegisters;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label25;
        private TextBox textBoxConnectTimeout;
        private FlowLayoutPanel flowLayoutPanel14;
        private Label label26;
        private ComboBox comboBoxSerialSettingsProtocol2;
    }
}
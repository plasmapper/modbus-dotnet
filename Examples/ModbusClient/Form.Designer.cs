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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInterface = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxConnectTimeout = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReadTimeout = new System.Windows.Forms.TextBox();
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelSerialSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSerialSettingsPortName = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSerialSettingsProtocol = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSerialSettingsStationAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSerialSettingsBaudRate = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerialSettingsDataBits = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSerialSettingsParity = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSerialSettingsStopBits = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSerialSettingsHandshake = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelNetworkSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNetworkSettingsIpAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNetworkSettingsPort = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxNetworkSettingsStationAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel22 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel23 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel24 = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxCoilsAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel25 = new System.Windows.Forms.FlowLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxCoilsCount = new System.Windows.Forms.TextBox();
            this.buttonCoilsRead = new System.Windows.Forms.Button();
            this.buttonCoilsWrite = new System.Windows.Forms.Button();
            this.dataGridViewCoilsValues = new System.Windows.Forms.DataGridView();
            this.columnCoils = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel20 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel21 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCoilAddress = new System.Windows.Forms.TextBox();
            this.checkBoxCoilValue = new System.Windows.Forms.CheckBox();
            this.buttonCoilWrite = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel26 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel27 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDiscreteInputsAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel28 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDiscreteInputsCount = new System.Windows.Forms.TextBox();
            this.buttonDiscreteInputsRead = new System.Windows.Forms.Button();
            this.dataGridViewDiscreteInputsValues = new System.Windows.Forms.DataGridView();
            this.columnDiscreteInputs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel29 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel30 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel31 = new System.Windows.Forms.FlowLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxHoldingRegistersAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel32 = new System.Windows.Forms.FlowLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxHoldingRegistersCount = new System.Windows.Forms.TextBox();
            this.buttonHoldingRegistersRead = new System.Windows.Forms.Button();
            this.buttonHoldingRegistersWrite = new System.Windows.Forms.Button();
            this.dataGridViewHoldingRegistersValues = new System.Windows.Forms.DataGridView();
            this.columnHoldingRegisters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel33 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel34 = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxHoldingRegisterAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel39 = new System.Windows.Forms.FlowLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxHoldingRegisterValue = new System.Windows.Forms.TextBox();
            this.buttonHoldingRegisterWrite = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel35 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel36 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel37 = new System.Windows.Forms.FlowLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxInputRegistersAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel38 = new System.Windows.Forms.FlowLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxInputRegistersCount = new System.Windows.Forms.TextBox();
            this.buttonInputRegistersRead = new System.Windows.Forms.Button();
            this.dataGridViewInputRegistersValues = new System.Windows.Forms.DataGridView();
            this.columnInputRegisters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dummy = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanelSerialSettings.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanelNetworkSettings.SuspendLayout();
            this.flowLayoutPanel17.SuspendLayout();
            this.flowLayoutPanel18.SuspendLayout();
            this.flowLayoutPanel19.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel22.SuspendLayout();
            this.flowLayoutPanel23.SuspendLayout();
            this.flowLayoutPanel24.SuspendLayout();
            this.flowLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoilsValues)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel20.SuspendLayout();
            this.flowLayoutPanel21.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.flowLayoutPanel26.SuspendLayout();
            this.flowLayoutPanel27.SuspendLayout();
            this.flowLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscreteInputsValues)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel29.SuspendLayout();
            this.flowLayoutPanel30.SuspendLayout();
            this.flowLayoutPanel31.SuspendLayout();
            this.flowLayoutPanel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldingRegistersValues)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel33.SuspendLayout();
            this.flowLayoutPanel34.SuspendLayout();
            this.flowLayoutPanel39.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.flowLayoutPanel35.SuspendLayout();
            this.flowLayoutPanel36.SuspendLayout();
            this.flowLayoutPanel37.SuspendLayout();
            this.flowLayoutPanel38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputRegistersValues)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanelSerialSettings);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanelNetworkSettings);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel15);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 473);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Controls.Add(this.checkBoxHex);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(441, 50);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Controls.Add(this.comboBoxInterface);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interface";
            // 
            // comboBoxInterface
            // 
            this.comboBoxInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterface.FormattingEnabled = true;
            this.comboBoxInterface.Items.AddRange(new object[] {
            "Serial",
            "Network"});
            this.comboBoxInterface.Location = new System.Drawing.Point(3, 18);
            this.comboBoxInterface.Name = "comboBoxInterface";
            this.comboBoxInterface.Size = new System.Drawing.Size(90, 23);
            this.comboBoxInterface.TabIndex = 4;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.label25);
            this.flowLayoutPanel8.Controls.Add(this.textBoxConnectTimeout);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(105, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(125, 44);
            this.flowLayoutPanel8.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "Connect timeout, ms";
            // 
            // textBoxConnectTimeout
            // 
            this.textBoxConnectTimeout.Location = new System.Drawing.Point(3, 18);
            this.textBoxConnectTimeout.Name = "textBoxConnectTimeout";
            this.textBoxConnectTimeout.Size = new System.Drawing.Size(90, 23);
            this.textBoxConnectTimeout.TabIndex = 3;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.label4);
            this.flowLayoutPanel7.Controls.Add(this.textBoxReadTimeout);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(236, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(106, 44);
            this.flowLayoutPanel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Read timeout, ms";
            // 
            // textBoxReadTimeout
            // 
            this.textBoxReadTimeout.Location = new System.Drawing.Point(3, 18);
            this.textBoxReadTimeout.Name = "textBoxReadTimeout";
            this.textBoxReadTimeout.Size = new System.Drawing.Size(90, 23);
            this.textBoxReadTimeout.TabIndex = 3;
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHex.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxHex.Location = new System.Drawing.Point(348, 22);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(90, 25);
            this.checkBoxHex.TabIndex = 5;
            this.checkBoxHex.Text = "checkBox1";
            this.checkBoxHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxHex.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSerialSettings
            // 
            this.flowLayoutPanelSerialSettings.AutoSize = true;
            this.flowLayoutPanelSerialSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanelSerialSettings.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanelSerialSettings.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanelSerialSettings.Name = "flowLayoutPanelSerialSettings";
            this.flowLayoutPanelSerialSettings.Size = new System.Drawing.Size(816, 50);
            this.flowLayoutPanelSerialSettings.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel9.Controls.Add(this.label5);
            this.flowLayoutPanel9.Controls.Add(this.comboBoxSerialSettingsPortName);
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel9.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port";
            // 
            // comboBoxSerialSettingsPortName
            // 
            this.comboBoxSerialSettingsPortName.FormattingEnabled = true;
            this.comboBoxSerialSettingsPortName.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSerialSettingsPortName.Name = "comboBoxSerialSettingsPortName";
            this.comboBoxSerialSettingsPortName.Size = new System.Drawing.Size(90, 23);
            this.comboBoxSerialSettingsPortName.TabIndex = 3;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel11.Controls.Add(this.label7);
            this.flowLayoutPanel11.Controls.Add(this.comboBoxSerialSettingsProtocol);
            this.flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(105, 3);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel11.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Protocol";
            // 
            // comboBoxSerialSettingsProtocol
            // 
            this.comboBoxSerialSettingsProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialSettingsProtocol.FormattingEnabled = true;
            this.comboBoxSerialSettingsProtocol.Items.AddRange(new object[] {
            "RTU",
            "ASCII"});
            this.comboBoxSerialSettingsProtocol.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSerialSettingsProtocol.Name = "comboBoxSerialSettingsProtocol";
            this.comboBoxSerialSettingsProtocol.Size = new System.Drawing.Size(90, 23);
            this.comboBoxSerialSettingsProtocol.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel10.Controls.Add(this.label6);
            this.flowLayoutPanel10.Controls.Add(this.textBoxSerialSettingsStationAddress);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(207, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel10.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Station address";
            // 
            // textBoxSerialSettingsStationAddress
            // 
            this.textBoxSerialSettingsStationAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxSerialSettingsStationAddress.Name = "textBoxSerialSettingsStationAddress";
            this.textBoxSerialSettingsStationAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxSerialSettingsStationAddress.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.textBoxSerialSettingsBaudRate);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(309, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baud rate";
            // 
            // textBoxSerialSettingsBaudRate
            // 
            this.textBoxSerialSettingsBaudRate.Location = new System.Drawing.Point(3, 18);
            this.textBoxSerialSettingsBaudRate.Name = "textBoxSerialSettingsBaudRate";
            this.textBoxSerialSettingsBaudRate.Size = new System.Drawing.Size(90, 23);
            this.textBoxSerialSettingsBaudRate.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.textBoxSerialSettingsDataBits);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(411, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data bits";
            // 
            // textBoxSerialSettingsDataBits
            // 
            this.textBoxSerialSettingsDataBits.Location = new System.Drawing.Point(3, 18);
            this.textBoxSerialSettingsDataBits.Name = "textBoxSerialSettingsDataBits";
            this.textBoxSerialSettingsDataBits.Size = new System.Drawing.Size(90, 23);
            this.textBoxSerialSettingsDataBits.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.flowLayoutPanel4.Controls.Add(this.comboBoxSerialSettingsParity);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(513, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Parity";
            // 
            // comboBoxSerialSettingsParity
            // 
            this.comboBoxSerialSettingsParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialSettingsParity.FormattingEnabled = true;
            this.comboBoxSerialSettingsParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxSerialSettingsParity.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSerialSettingsParity.Name = "comboBoxSerialSettingsParity";
            this.comboBoxSerialSettingsParity.Size = new System.Drawing.Size(90, 23);
            this.comboBoxSerialSettingsParity.TabIndex = 3;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.AutoSize = true;
            this.flowLayoutPanel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel12.Controls.Add(this.label9);
            this.flowLayoutPanel12.Controls.Add(this.comboBoxSerialSettingsStopBits);
            this.flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel12.Location = new System.Drawing.Point(615, 3);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel12.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stop bits";
            // 
            // comboBoxSerialSettingsStopBits
            // 
            this.comboBoxSerialSettingsStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialSettingsStopBits.FormattingEnabled = true;
            this.comboBoxSerialSettingsStopBits.Items.AddRange(new object[] {
            "None",
            "1.0",
            "2.0",
            "1.5"});
            this.comboBoxSerialSettingsStopBits.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSerialSettingsStopBits.Name = "comboBoxSerialSettingsStopBits";
            this.comboBoxSerialSettingsStopBits.Size = new System.Drawing.Size(90, 23);
            this.comboBoxSerialSettingsStopBits.TabIndex = 3;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.AutoSize = true;
            this.flowLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel13.Controls.Add(this.label10);
            this.flowLayoutPanel13.Controls.Add(this.comboBoxSerialSettingsHandshake);
            this.flowLayoutPanel13.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel13.Location = new System.Drawing.Point(717, 3);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel13.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Handshake";
            // 
            // comboBoxSerialSettingsHandshake
            // 
            this.comboBoxSerialSettingsHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialSettingsHandshake.FormattingEnabled = true;
            this.comboBoxSerialSettingsHandshake.Items.AddRange(new object[] {
            "None",
            "XON/XOFF",
            "RTS",
            "RTS XON/XOFF"});
            this.comboBoxSerialSettingsHandshake.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSerialSettingsHandshake.Name = "comboBoxSerialSettingsHandshake";
            this.comboBoxSerialSettingsHandshake.Size = new System.Drawing.Size(90, 23);
            this.comboBoxSerialSettingsHandshake.TabIndex = 3;
            // 
            // flowLayoutPanelNetworkSettings
            // 
            this.flowLayoutPanelNetworkSettings.AutoSize = true;
            this.flowLayoutPanelNetworkSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelNetworkSettings.Controls.Add(this.flowLayoutPanel17);
            this.flowLayoutPanelNetworkSettings.Controls.Add(this.flowLayoutPanel18);
            this.flowLayoutPanelNetworkSettings.Controls.Add(this.flowLayoutPanel19);
            this.flowLayoutPanelNetworkSettings.Location = new System.Drawing.Point(3, 115);
            this.flowLayoutPanelNetworkSettings.Name = "flowLayoutPanelNetworkSettings";
            this.flowLayoutPanelNetworkSettings.Size = new System.Drawing.Size(306, 50);
            this.flowLayoutPanelNetworkSettings.TabIndex = 2;
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.AutoSize = true;
            this.flowLayoutPanel17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel17.Controls.Add(this.label13);
            this.flowLayoutPanel17.Controls.Add(this.textBoxNetworkSettingsIpAddress);
            this.flowLayoutPanel17.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel17.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "IP address";
            // 
            // textBoxNetworkSettingsIpAddress
            // 
            this.textBoxNetworkSettingsIpAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxNetworkSettingsIpAddress.Name = "textBoxNetworkSettingsIpAddress";
            this.textBoxNetworkSettingsIpAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxNetworkSettingsIpAddress.TabIndex = 3;
            // 
            // flowLayoutPanel18
            // 
            this.flowLayoutPanel18.AutoSize = true;
            this.flowLayoutPanel18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel18.Controls.Add(this.label14);
            this.flowLayoutPanel18.Controls.Add(this.textBoxNetworkSettingsPort);
            this.flowLayoutPanel18.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel18.Location = new System.Drawing.Point(105, 3);
            this.flowLayoutPanel18.Name = "flowLayoutPanel18";
            this.flowLayoutPanel18.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel18.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Port";
            // 
            // textBoxNetworkSettingsPort
            // 
            this.textBoxNetworkSettingsPort.Location = new System.Drawing.Point(3, 18);
            this.textBoxNetworkSettingsPort.Name = "textBoxNetworkSettingsPort";
            this.textBoxNetworkSettingsPort.Size = new System.Drawing.Size(90, 23);
            this.textBoxNetworkSettingsPort.TabIndex = 3;
            // 
            // flowLayoutPanel19
            // 
            this.flowLayoutPanel19.AutoSize = true;
            this.flowLayoutPanel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel19.Controls.Add(this.label15);
            this.flowLayoutPanel19.Controls.Add(this.textBoxNetworkSettingsStationAddress);
            this.flowLayoutPanel19.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel19.Location = new System.Drawing.Point(207, 3);
            this.flowLayoutPanel19.Name = "flowLayoutPanel19";
            this.flowLayoutPanel19.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel19.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Station address";
            // 
            // textBoxNetworkSettingsStationAddress
            // 
            this.textBoxNetworkSettingsStationAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxNetworkSettingsStationAddress.Name = "textBoxNetworkSettingsStationAddress";
            this.textBoxNetworkSettingsStationAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxNetworkSettingsStationAddress.TabIndex = 3;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.AutoSize = true;
            this.flowLayoutPanel15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel15.Controls.Add(this.groupBox1);
            this.flowLayoutPanel15.Controls.Add(this.groupBox2);
            this.flowLayoutPanel15.Controls.Add(this.groupBox3);
            this.flowLayoutPanel15.Controls.Add(this.groupBox4);
            this.flowLayoutPanel15.Controls.Add(this.groupBox5);
            this.flowLayoutPanel15.Controls.Add(this.groupBox6);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(3, 171);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(942, 299);
            this.flowLayoutPanel15.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.flowLayoutPanel22);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coils";
            // 
            // flowLayoutPanel22
            // 
            this.flowLayoutPanel22.AutoSize = true;
            this.flowLayoutPanel22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel22.Controls.Add(this.flowLayoutPanel23);
            this.flowLayoutPanel22.Controls.Add(this.dataGridViewCoilsValues);
            this.flowLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel22.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel22.Name = "flowLayoutPanel22";
            this.flowLayoutPanel22.Size = new System.Drawing.Size(159, 271);
            this.flowLayoutPanel22.TabIndex = 0;
            // 
            // flowLayoutPanel23
            // 
            this.flowLayoutPanel23.AutoSize = true;
            this.flowLayoutPanel23.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel23.Controls.Add(this.flowLayoutPanel24);
            this.flowLayoutPanel23.Controls.Add(this.flowLayoutPanel25);
            this.flowLayoutPanel23.Controls.Add(this.buttonCoilsRead);
            this.flowLayoutPanel23.Controls.Add(this.buttonCoilsWrite);
            this.flowLayoutPanel23.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel23.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel23.Name = "flowLayoutPanel23";
            this.flowLayoutPanel23.Size = new System.Drawing.Size(102, 158);
            this.flowLayoutPanel23.TabIndex = 1;
            // 
            // flowLayoutPanel24
            // 
            this.flowLayoutPanel24.AutoSize = true;
            this.flowLayoutPanel24.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel24.Controls.Add(this.label17);
            this.flowLayoutPanel24.Controls.Add(this.textBoxCoilsAddress);
            this.flowLayoutPanel24.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel24.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel24.Name = "flowLayoutPanel24";
            this.flowLayoutPanel24.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel24.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Address";
            // 
            // textBoxCoilsAddress
            // 
            this.textBoxCoilsAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoilsAddress.Name = "textBoxCoilsAddress";
            this.textBoxCoilsAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxCoilsAddress.TabIndex = 3;
            // 
            // flowLayoutPanel25
            // 
            this.flowLayoutPanel25.AutoSize = true;
            this.flowLayoutPanel25.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel25.Controls.Add(this.label18);
            this.flowLayoutPanel25.Controls.Add(this.textBoxCoilsCount);
            this.flowLayoutPanel25.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel25.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel25.Name = "flowLayoutPanel25";
            this.flowLayoutPanel25.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel25.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Count";
            // 
            // textBoxCoilsCount
            // 
            this.textBoxCoilsCount.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoilsCount.Name = "textBoxCoilsCount";
            this.textBoxCoilsCount.Size = new System.Drawing.Size(90, 23);
            this.textBoxCoilsCount.TabIndex = 3;
            // 
            // buttonCoilsRead
            // 
            this.buttonCoilsRead.Location = new System.Drawing.Point(3, 103);
            this.buttonCoilsRead.Name = "buttonCoilsRead";
            this.buttonCoilsRead.Size = new System.Drawing.Size(90, 23);
            this.buttonCoilsRead.TabIndex = 4;
            this.buttonCoilsRead.Text = "Read";
            this.buttonCoilsRead.UseVisualStyleBackColor = true;
            // 
            // buttonCoilsWrite
            // 
            this.buttonCoilsWrite.Location = new System.Drawing.Point(3, 132);
            this.buttonCoilsWrite.Name = "buttonCoilsWrite";
            this.buttonCoilsWrite.Size = new System.Drawing.Size(90, 23);
            this.buttonCoilsWrite.TabIndex = 10;
            this.buttonCoilsWrite.Text = "Write";
            this.buttonCoilsWrite.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCoilsValues
            // 
            this.dataGridViewCoilsValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCoilsValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoilsValues.ColumnHeadersVisible = false;
            this.dataGridViewCoilsValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCoils});
            this.dataGridViewCoilsValues.Location = new System.Drawing.Point(111, 3);
            this.dataGridViewCoilsValues.Name = "dataGridViewCoilsValues";
            this.dataGridViewCoilsValues.RowHeadersVisible = false;
            this.dataGridViewCoilsValues.RowTemplate.Height = 25;
            this.dataGridViewCoilsValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCoilsValues.Size = new System.Drawing.Size(45, 265);
            this.dataGridViewCoilsValues.TabIndex = 0;
            // 
            // columnCoils
            // 
            this.columnCoils.HeaderText = "Column1";
            this.columnCoils.Name = "columnCoils";
            this.columnCoils.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCoils.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnCoils.Width = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.flowLayoutPanel20);
            this.groupBox2.Location = new System.Drawing.Point(174, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 126);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coil";
            // 
            // flowLayoutPanel20
            // 
            this.flowLayoutPanel20.AutoSize = true;
            this.flowLayoutPanel20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel20.Controls.Add(this.flowLayoutPanel21);
            this.flowLayoutPanel20.Controls.Add(this.checkBoxCoilValue);
            this.flowLayoutPanel20.Controls.Add(this.buttonCoilWrite);
            this.flowLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel20.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel20.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel20.Name = "flowLayoutPanel20";
            this.flowLayoutPanel20.Size = new System.Drawing.Size(102, 104);
            this.flowLayoutPanel20.TabIndex = 1;
            // 
            // flowLayoutPanel21
            // 
            this.flowLayoutPanel21.AutoSize = true;
            this.flowLayoutPanel21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel21.Controls.Add(this.label11);
            this.flowLayoutPanel21.Controls.Add(this.textBoxCoilAddress);
            this.flowLayoutPanel21.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel21.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel21.Name = "flowLayoutPanel21";
            this.flowLayoutPanel21.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel21.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Address";
            // 
            // textBoxCoilAddress
            // 
            this.textBoxCoilAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoilAddress.Name = "textBoxCoilAddress";
            this.textBoxCoilAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxCoilAddress.TabIndex = 3;
            // 
            // checkBoxCoilValue
            // 
            this.checkBoxCoilValue.AutoSize = true;
            this.checkBoxCoilValue.Location = new System.Drawing.Point(3, 53);
            this.checkBoxCoilValue.Name = "checkBoxCoilValue";
            this.checkBoxCoilValue.Size = new System.Drawing.Size(54, 19);
            this.checkBoxCoilValue.TabIndex = 11;
            this.checkBoxCoilValue.Text = "Value";
            this.checkBoxCoilValue.UseVisualStyleBackColor = true;
            // 
            // buttonCoilWrite
            // 
            this.buttonCoilWrite.Location = new System.Drawing.Point(3, 78);
            this.buttonCoilWrite.Name = "buttonCoilWrite";
            this.buttonCoilWrite.Size = new System.Drawing.Size(90, 23);
            this.buttonCoilWrite.TabIndex = 10;
            this.buttonCoilWrite.Text = "Write";
            this.buttonCoilWrite.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.flowLayoutPanel16);
            this.groupBox3.Location = new System.Drawing.Point(288, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 293);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discrete inputs";
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.AutoSize = true;
            this.flowLayoutPanel16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel16.Controls.Add(this.flowLayoutPanel26);
            this.flowLayoutPanel16.Controls.Add(this.dataGridViewDiscreteInputsValues);
            this.flowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel16.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(159, 271);
            this.flowLayoutPanel16.TabIndex = 0;
            // 
            // flowLayoutPanel26
            // 
            this.flowLayoutPanel26.AutoSize = true;
            this.flowLayoutPanel26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel26.Controls.Add(this.flowLayoutPanel27);
            this.flowLayoutPanel26.Controls.Add(this.flowLayoutPanel28);
            this.flowLayoutPanel26.Controls.Add(this.buttonDiscreteInputsRead);
            this.flowLayoutPanel26.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel26.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel26.Name = "flowLayoutPanel26";
            this.flowLayoutPanel26.Size = new System.Drawing.Size(102, 129);
            this.flowLayoutPanel26.TabIndex = 1;
            // 
            // flowLayoutPanel27
            // 
            this.flowLayoutPanel27.AutoSize = true;
            this.flowLayoutPanel27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel27.Controls.Add(this.label12);
            this.flowLayoutPanel27.Controls.Add(this.textBoxDiscreteInputsAddress);
            this.flowLayoutPanel27.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel27.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel27.Name = "flowLayoutPanel27";
            this.flowLayoutPanel27.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel27.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Address";
            // 
            // textBoxDiscreteInputsAddress
            // 
            this.textBoxDiscreteInputsAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxDiscreteInputsAddress.Name = "textBoxDiscreteInputsAddress";
            this.textBoxDiscreteInputsAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxDiscreteInputsAddress.TabIndex = 3;
            // 
            // flowLayoutPanel28
            // 
            this.flowLayoutPanel28.AutoSize = true;
            this.flowLayoutPanel28.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel28.Controls.Add(this.label16);
            this.flowLayoutPanel28.Controls.Add(this.textBoxDiscreteInputsCount);
            this.flowLayoutPanel28.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel28.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel28.Name = "flowLayoutPanel28";
            this.flowLayoutPanel28.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel28.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Count";
            // 
            // textBoxDiscreteInputsCount
            // 
            this.textBoxDiscreteInputsCount.Location = new System.Drawing.Point(3, 18);
            this.textBoxDiscreteInputsCount.Name = "textBoxDiscreteInputsCount";
            this.textBoxDiscreteInputsCount.Size = new System.Drawing.Size(90, 23);
            this.textBoxDiscreteInputsCount.TabIndex = 3;
            // 
            // buttonDiscreteInputsRead
            // 
            this.buttonDiscreteInputsRead.Location = new System.Drawing.Point(3, 103);
            this.buttonDiscreteInputsRead.Name = "buttonDiscreteInputsRead";
            this.buttonDiscreteInputsRead.Size = new System.Drawing.Size(90, 23);
            this.buttonDiscreteInputsRead.TabIndex = 4;
            this.buttonDiscreteInputsRead.Text = "Read";
            this.buttonDiscreteInputsRead.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDiscreteInputsValues
            // 
            this.dataGridViewDiscreteInputsValues.AllowUserToAddRows = false;
            this.dataGridViewDiscreteInputsValues.AllowUserToDeleteRows = false;
            this.dataGridViewDiscreteInputsValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDiscreteInputsValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscreteInputsValues.ColumnHeadersVisible = false;
            this.dataGridViewDiscreteInputsValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDiscreteInputs});
            this.dataGridViewDiscreteInputsValues.Location = new System.Drawing.Point(111, 3);
            this.dataGridViewDiscreteInputsValues.Name = "dataGridViewDiscreteInputsValues";
            this.dataGridViewDiscreteInputsValues.ReadOnly = true;
            this.dataGridViewDiscreteInputsValues.RowHeadersVisible = false;
            this.dataGridViewDiscreteInputsValues.RowTemplate.Height = 25;
            this.dataGridViewDiscreteInputsValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDiscreteInputsValues.Size = new System.Drawing.Size(45, 265);
            this.dataGridViewDiscreteInputsValues.TabIndex = 0;
            // 
            // columnDiscreteInputs
            // 
            this.columnDiscreteInputs.HeaderText = "Column1";
            this.columnDiscreteInputs.Name = "columnDiscreteInputs";
            this.columnDiscreteInputs.ReadOnly = true;
            this.columnDiscreteInputs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDiscreteInputs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnDiscreteInputs.Width = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.flowLayoutPanel29);
            this.groupBox4.Location = new System.Drawing.Point(459, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 293);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Holding registers";
            // 
            // flowLayoutPanel29
            // 
            this.flowLayoutPanel29.AutoSize = true;
            this.flowLayoutPanel29.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel29.Controls.Add(this.flowLayoutPanel30);
            this.flowLayoutPanel29.Controls.Add(this.dataGridViewHoldingRegistersValues);
            this.flowLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel29.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel29.Name = "flowLayoutPanel29";
            this.flowLayoutPanel29.Size = new System.Drawing.Size(174, 271);
            this.flowLayoutPanel29.TabIndex = 0;
            // 
            // flowLayoutPanel30
            // 
            this.flowLayoutPanel30.AutoSize = true;
            this.flowLayoutPanel30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel30.Controls.Add(this.flowLayoutPanel31);
            this.flowLayoutPanel30.Controls.Add(this.flowLayoutPanel32);
            this.flowLayoutPanel30.Controls.Add(this.buttonHoldingRegistersRead);
            this.flowLayoutPanel30.Controls.Add(this.buttonHoldingRegistersWrite);
            this.flowLayoutPanel30.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel30.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel30.Name = "flowLayoutPanel30";
            this.flowLayoutPanel30.Size = new System.Drawing.Size(102, 158);
            this.flowLayoutPanel30.TabIndex = 1;
            // 
            // flowLayoutPanel31
            // 
            this.flowLayoutPanel31.AutoSize = true;
            this.flowLayoutPanel31.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel31.Controls.Add(this.label19);
            this.flowLayoutPanel31.Controls.Add(this.textBoxHoldingRegistersAddress);
            this.flowLayoutPanel31.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel31.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel31.Name = "flowLayoutPanel31";
            this.flowLayoutPanel31.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel31.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Address";
            // 
            // textBoxHoldingRegistersAddress
            // 
            this.textBoxHoldingRegistersAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxHoldingRegistersAddress.Name = "textBoxHoldingRegistersAddress";
            this.textBoxHoldingRegistersAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxHoldingRegistersAddress.TabIndex = 3;
            // 
            // flowLayoutPanel32
            // 
            this.flowLayoutPanel32.AutoSize = true;
            this.flowLayoutPanel32.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel32.Controls.Add(this.label20);
            this.flowLayoutPanel32.Controls.Add(this.textBoxHoldingRegistersCount);
            this.flowLayoutPanel32.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel32.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel32.Name = "flowLayoutPanel32";
            this.flowLayoutPanel32.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel32.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Count";
            // 
            // textBoxHoldingRegistersCount
            // 
            this.textBoxHoldingRegistersCount.Location = new System.Drawing.Point(3, 18);
            this.textBoxHoldingRegistersCount.Name = "textBoxHoldingRegistersCount";
            this.textBoxHoldingRegistersCount.Size = new System.Drawing.Size(90, 23);
            this.textBoxHoldingRegistersCount.TabIndex = 3;
            // 
            // buttonHoldingRegistersRead
            // 
            this.buttonHoldingRegistersRead.Location = new System.Drawing.Point(3, 103);
            this.buttonHoldingRegistersRead.Name = "buttonHoldingRegistersRead";
            this.buttonHoldingRegistersRead.Size = new System.Drawing.Size(90, 23);
            this.buttonHoldingRegistersRead.TabIndex = 4;
            this.buttonHoldingRegistersRead.Text = "Read";
            this.buttonHoldingRegistersRead.UseVisualStyleBackColor = true;
            // 
            // buttonHoldingRegistersWrite
            // 
            this.buttonHoldingRegistersWrite.Location = new System.Drawing.Point(3, 132);
            this.buttonHoldingRegistersWrite.Name = "buttonHoldingRegistersWrite";
            this.buttonHoldingRegistersWrite.Size = new System.Drawing.Size(90, 23);
            this.buttonHoldingRegistersWrite.TabIndex = 10;
            this.buttonHoldingRegistersWrite.Text = "Write";
            this.buttonHoldingRegistersWrite.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHoldingRegistersValues
            // 
            this.dataGridViewHoldingRegistersValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHoldingRegistersValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoldingRegistersValues.ColumnHeadersVisible = false;
            this.dataGridViewHoldingRegistersValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnHoldingRegisters});
            this.dataGridViewHoldingRegistersValues.Location = new System.Drawing.Point(111, 3);
            this.dataGridViewHoldingRegistersValues.Name = "dataGridViewHoldingRegistersValues";
            this.dataGridViewHoldingRegistersValues.RowHeadersVisible = false;
            this.dataGridViewHoldingRegistersValues.RowTemplate.Height = 25;
            this.dataGridViewHoldingRegistersValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewHoldingRegistersValues.Size = new System.Drawing.Size(60, 265);
            this.dataGridViewHoldingRegistersValues.TabIndex = 0;
            // 
            // columnHoldingRegisters
            // 
            this.columnHoldingRegisters.HeaderText = "Column1";
            this.columnHoldingRegisters.Name = "columnHoldingRegisters";
            this.columnHoldingRegisters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnHoldingRegisters.Width = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.flowLayoutPanel33);
            this.groupBox5.Location = new System.Drawing.Point(645, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(108, 151);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Holding register";
            // 
            // flowLayoutPanel33
            // 
            this.flowLayoutPanel33.AutoSize = true;
            this.flowLayoutPanel33.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel33.Controls.Add(this.flowLayoutPanel34);
            this.flowLayoutPanel33.Controls.Add(this.flowLayoutPanel39);
            this.flowLayoutPanel33.Controls.Add(this.buttonHoldingRegisterWrite);
            this.flowLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel33.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel33.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel33.Name = "flowLayoutPanel33";
            this.flowLayoutPanel33.Size = new System.Drawing.Size(102, 129);
            this.flowLayoutPanel33.TabIndex = 1;
            // 
            // flowLayoutPanel34
            // 
            this.flowLayoutPanel34.AutoSize = true;
            this.flowLayoutPanel34.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel34.Controls.Add(this.label21);
            this.flowLayoutPanel34.Controls.Add(this.textBoxHoldingRegisterAddress);
            this.flowLayoutPanel34.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel34.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel34.Name = "flowLayoutPanel34";
            this.flowLayoutPanel34.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel34.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Address";
            // 
            // textBoxHoldingRegisterAddress
            // 
            this.textBoxHoldingRegisterAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxHoldingRegisterAddress.Name = "textBoxHoldingRegisterAddress";
            this.textBoxHoldingRegisterAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxHoldingRegisterAddress.TabIndex = 3;
            // 
            // flowLayoutPanel39
            // 
            this.flowLayoutPanel39.AutoSize = true;
            this.flowLayoutPanel39.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel39.Controls.Add(this.label24);
            this.flowLayoutPanel39.Controls.Add(this.textBoxHoldingRegisterValue);
            this.flowLayoutPanel39.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel39.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel39.Name = "flowLayoutPanel39";
            this.flowLayoutPanel39.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel39.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "Value";
            // 
            // textBoxHoldingRegisterValue
            // 
            this.textBoxHoldingRegisterValue.Location = new System.Drawing.Point(3, 18);
            this.textBoxHoldingRegisterValue.Name = "textBoxHoldingRegisterValue";
            this.textBoxHoldingRegisterValue.Size = new System.Drawing.Size(90, 23);
            this.textBoxHoldingRegisterValue.TabIndex = 3;
            // 
            // buttonHoldingRegisterWrite
            // 
            this.buttonHoldingRegisterWrite.Location = new System.Drawing.Point(3, 103);
            this.buttonHoldingRegisterWrite.Name = "buttonHoldingRegisterWrite";
            this.buttonHoldingRegisterWrite.Size = new System.Drawing.Size(90, 23);
            this.buttonHoldingRegisterWrite.TabIndex = 10;
            this.buttonHoldingRegisterWrite.Text = "Write";
            this.buttonHoldingRegisterWrite.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.Controls.Add(this.flowLayoutPanel35);
            this.groupBox6.Location = new System.Drawing.Point(759, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 293);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input registers";
            // 
            // flowLayoutPanel35
            // 
            this.flowLayoutPanel35.AutoSize = true;
            this.flowLayoutPanel35.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel35.Controls.Add(this.flowLayoutPanel36);
            this.flowLayoutPanel35.Controls.Add(this.dataGridViewInputRegistersValues);
            this.flowLayoutPanel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel35.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel35.Name = "flowLayoutPanel35";
            this.flowLayoutPanel35.Size = new System.Drawing.Size(174, 271);
            this.flowLayoutPanel35.TabIndex = 0;
            // 
            // flowLayoutPanel36
            // 
            this.flowLayoutPanel36.AutoSize = true;
            this.flowLayoutPanel36.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel36.Controls.Add(this.flowLayoutPanel37);
            this.flowLayoutPanel36.Controls.Add(this.flowLayoutPanel38);
            this.flowLayoutPanel36.Controls.Add(this.buttonInputRegistersRead);
            this.flowLayoutPanel36.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel36.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel36.Name = "flowLayoutPanel36";
            this.flowLayoutPanel36.Size = new System.Drawing.Size(102, 129);
            this.flowLayoutPanel36.TabIndex = 1;
            // 
            // flowLayoutPanel37
            // 
            this.flowLayoutPanel37.AutoSize = true;
            this.flowLayoutPanel37.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel37.Controls.Add(this.label22);
            this.flowLayoutPanel37.Controls.Add(this.textBoxInputRegistersAddress);
            this.flowLayoutPanel37.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel37.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel37.Name = "flowLayoutPanel37";
            this.flowLayoutPanel37.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel37.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Address";
            // 
            // textBoxInputRegistersAddress
            // 
            this.textBoxInputRegistersAddress.Location = new System.Drawing.Point(3, 18);
            this.textBoxInputRegistersAddress.Name = "textBoxInputRegistersAddress";
            this.textBoxInputRegistersAddress.Size = new System.Drawing.Size(90, 23);
            this.textBoxInputRegistersAddress.TabIndex = 3;
            // 
            // flowLayoutPanel38
            // 
            this.flowLayoutPanel38.AutoSize = true;
            this.flowLayoutPanel38.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel38.Controls.Add(this.label23);
            this.flowLayoutPanel38.Controls.Add(this.textBoxInputRegistersCount);
            this.flowLayoutPanel38.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel38.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel38.Name = "flowLayoutPanel38";
            this.flowLayoutPanel38.Size = new System.Drawing.Size(96, 44);
            this.flowLayoutPanel38.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "Count";
            // 
            // textBoxInputRegistersCount
            // 
            this.textBoxInputRegistersCount.Location = new System.Drawing.Point(3, 18);
            this.textBoxInputRegistersCount.Name = "textBoxInputRegistersCount";
            this.textBoxInputRegistersCount.Size = new System.Drawing.Size(90, 23);
            this.textBoxInputRegistersCount.TabIndex = 3;
            // 
            // buttonInputRegistersRead
            // 
            this.buttonInputRegistersRead.Location = new System.Drawing.Point(3, 103);
            this.buttonInputRegistersRead.Name = "buttonInputRegistersRead";
            this.buttonInputRegistersRead.Size = new System.Drawing.Size(90, 23);
            this.buttonInputRegistersRead.TabIndex = 4;
            this.buttonInputRegistersRead.Text = "Read";
            this.buttonInputRegistersRead.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInputRegistersValues
            // 
            this.dataGridViewInputRegistersValues.AllowUserToAddRows = false;
            this.dataGridViewInputRegistersValues.AllowUserToDeleteRows = false;
            this.dataGridViewInputRegistersValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInputRegistersValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputRegistersValues.ColumnHeadersVisible = false;
            this.dataGridViewInputRegistersValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnInputRegisters});
            this.dataGridViewInputRegistersValues.Location = new System.Drawing.Point(111, 3);
            this.dataGridViewInputRegistersValues.Name = "dataGridViewInputRegistersValues";
            this.dataGridViewInputRegistersValues.ReadOnly = true;
            this.dataGridViewInputRegistersValues.RowHeadersVisible = false;
            this.dataGridViewInputRegistersValues.RowTemplate.Height = 25;
            this.dataGridViewInputRegistersValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInputRegistersValues.Size = new System.Drawing.Size(60, 265);
            this.dataGridViewInputRegistersValues.TabIndex = 0;
            // 
            // columnInputRegisters
            // 
            this.columnInputRegisters.HeaderText = "Column1";
            this.columnInputRegisters.Name = "columnInputRegisters";
            this.columnInputRegisters.ReadOnly = true;
            this.columnInputRegisters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnInputRegisters.Width = 5;
            // 
            // dummy
            // 
            this.dummy.Location = new System.Drawing.Point(0, 0);
            this.dummy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dummy.Name = "dummy";
            this.dummy.Size = new System.Drawing.Size(0, 0);
            this.dummy.TabIndex = 1;
            this.dummy.Text = "button1";
            this.dummy.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 504);
            this.Controls.Add(this.dummy);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form";
            this.Text = "Modbus Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanelSerialSettings.ResumeLayout(false);
            this.flowLayoutPanelSerialSettings.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanelNetworkSettings.ResumeLayout(false);
            this.flowLayoutPanelNetworkSettings.PerformLayout();
            this.flowLayoutPanel17.ResumeLayout(false);
            this.flowLayoutPanel17.PerformLayout();
            this.flowLayoutPanel18.ResumeLayout(false);
            this.flowLayoutPanel18.PerformLayout();
            this.flowLayoutPanel19.ResumeLayout(false);
            this.flowLayoutPanel19.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel22.ResumeLayout(false);
            this.flowLayoutPanel22.PerformLayout();
            this.flowLayoutPanel23.ResumeLayout(false);
            this.flowLayoutPanel23.PerformLayout();
            this.flowLayoutPanel24.ResumeLayout(false);
            this.flowLayoutPanel24.PerformLayout();
            this.flowLayoutPanel25.ResumeLayout(false);
            this.flowLayoutPanel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoilsValues)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel20.ResumeLayout(false);
            this.flowLayoutPanel20.PerformLayout();
            this.flowLayoutPanel21.ResumeLayout(false);
            this.flowLayoutPanel21.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.flowLayoutPanel26.ResumeLayout(false);
            this.flowLayoutPanel26.PerformLayout();
            this.flowLayoutPanel27.ResumeLayout(false);
            this.flowLayoutPanel27.PerformLayout();
            this.flowLayoutPanel28.ResumeLayout(false);
            this.flowLayoutPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscreteInputsValues)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel29.ResumeLayout(false);
            this.flowLayoutPanel29.PerformLayout();
            this.flowLayoutPanel30.ResumeLayout(false);
            this.flowLayoutPanel30.PerformLayout();
            this.flowLayoutPanel31.ResumeLayout(false);
            this.flowLayoutPanel31.PerformLayout();
            this.flowLayoutPanel32.ResumeLayout(false);
            this.flowLayoutPanel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldingRegistersValues)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.flowLayoutPanel33.ResumeLayout(false);
            this.flowLayoutPanel33.PerformLayout();
            this.flowLayoutPanel34.ResumeLayout(false);
            this.flowLayoutPanel34.PerformLayout();
            this.flowLayoutPanel39.ResumeLayout(false);
            this.flowLayoutPanel39.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.flowLayoutPanel35.ResumeLayout(false);
            this.flowLayoutPanel35.PerformLayout();
            this.flowLayoutPanel36.ResumeLayout(false);
            this.flowLayoutPanel36.PerformLayout();
            this.flowLayoutPanel37.ResumeLayout(false);
            this.flowLayoutPanel37.PerformLayout();
            this.flowLayoutPanel38.ResumeLayout(false);
            this.flowLayoutPanel38.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputRegistersValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox comboBoxSerialSettingsProtocol;
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
    }
}
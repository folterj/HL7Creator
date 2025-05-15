namespace HL7Creator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.hl7Text = new System.Windows.Forms.RichTextBox();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.lengthText = new System.Windows.Forms.TextBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.generalGroup = new System.Windows.Forms.GroupBox();
			this.timeSyncCheck = new System.Windows.Forms.CheckBox();
			this.gatewayEuiButton = new System.Windows.Forms.Button();
			this.deviceEuiButton = new System.Windows.Forms.Button();
			this.textConstantsCheck = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.gatewayEuiText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gatewayNameText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.deviceEuiText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.deviceTypeCombo = new System.Windows.Forms.ComboBox();
			this.hl7Group = new System.Windows.Forms.GroupBox();
			this.obsGroup = new System.Windows.Forms.GroupBox();
			this.obsOffsetMinsText = new System.Windows.Forms.TextBox();
			this.obsOffsetHoursText = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.obsOffsetSignCombo = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.clearObsButton = new System.Windows.Forms.Button();
			this.removeObsButton = new System.Windows.Forms.Button();
			this.addObsButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.obsTypeCombo = new System.Windows.Forms.ComboBox();
			this.obsListView = new System.Windows.Forms.ListView();
			this.TimestampColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.unitsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.obsDateTime = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.obsUnitsCombo = new System.Windows.Forms.ComboBox();
			this.obsValueText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.menuToolStrip = new System.Windows.Forms.ToolStrip();
			this.createButton = new System.Windows.Forms.ToolStripButton();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.clearButton = new System.Windows.Forms.ToolStripButton();
			this.wrapButton = new System.Windows.Forms.ToolStripButton();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.splitter = new System.Windows.Forms.Splitter();
			this.contextMenu.SuspendLayout();
			this.generalGroup.SuspendLayout();
			this.hl7Group.SuspendLayout();
			this.obsGroup.SuspendLayout();
			this.menuToolStrip.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// hl7Text
			// 
			this.hl7Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hl7Text.BackColor = System.Drawing.Color.White;
			this.hl7Text.ContextMenuStrip = this.contextMenu;
			this.hl7Text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hl7Text.Location = new System.Drawing.Point(6, 19);
			this.hl7Text.Name = "hl7Text";
			this.hl7Text.ReadOnly = true;
			this.hl7Text.Size = new System.Drawing.Size(572, 167);
			this.hl7Text.TabIndex = 0;
			this.hl7Text.Text = "";
			this.hl7Text.WordWrap = false;
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem});
			this.contextMenu.Name = "contextMenuStrip";
			this.contextMenu.Size = new System.Drawing.Size(165, 76);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(463, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "HL7 length";
			// 
			// lengthText
			// 
			this.lengthText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lengthText.Location = new System.Drawing.Point(528, 192);
			this.lengthText.Name = "lengthText";
			this.lengthText.ReadOnly = true;
			this.lengthText.Size = new System.Drawing.Size(50, 20);
			this.lengthText.TabIndex = 2;
			this.lengthText.TabStop = false;
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "HL7 files (*.hl7)|*.hl7|Text files (*.txt)|*.txt|All files (*.*)|*.*";
			// 
			// generalGroup
			// 
			this.generalGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.generalGroup.Controls.Add(this.timeSyncCheck);
			this.generalGroup.Controls.Add(this.gatewayEuiButton);
			this.generalGroup.Controls.Add(this.deviceEuiButton);
			this.generalGroup.Controls.Add(this.textConstantsCheck);
			this.generalGroup.Controls.Add(this.label5);
			this.generalGroup.Controls.Add(this.gatewayEuiText);
			this.generalGroup.Controls.Add(this.label4);
			this.generalGroup.Controls.Add(this.gatewayNameText);
			this.generalGroup.Controls.Add(this.label3);
			this.generalGroup.Controls.Add(this.deviceEuiText);
			this.generalGroup.Controls.Add(this.label2);
			this.generalGroup.Controls.Add(this.deviceTypeCombo);
			this.generalGroup.Location = new System.Drawing.Point(0, 42);
			this.generalGroup.Name = "generalGroup";
			this.generalGroup.Size = new System.Drawing.Size(584, 99);
			this.generalGroup.TabIndex = 1;
			this.generalGroup.TabStop = false;
			this.generalGroup.Text = "General";
			// 
			// timeSyncCheck
			// 
			this.timeSyncCheck.AutoSize = true;
			this.timeSyncCheck.Location = new System.Drawing.Point(257, 71);
			this.timeSyncCheck.Name = "timeSyncCheck";
			this.timeSyncCheck.Size = new System.Drawing.Size(137, 17);
			this.timeSyncCheck.TabIndex = 11;
			this.timeSyncCheck.Text = "Add time syncronisation";
			this.timeSyncCheck.UseVisualStyleBackColor = true;
			// 
			// gatewayEuiButton
			// 
			this.gatewayEuiButton.BackgroundImage = global::HL7Creator.Properties.Resources.repeat32;
			this.gatewayEuiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.gatewayEuiButton.Location = new System.Drawing.Point(465, 45);
			this.gatewayEuiButton.Name = "gatewayEuiButton";
			this.gatewayEuiButton.Size = new System.Drawing.Size(20, 20);
			this.gatewayEuiButton.TabIndex = 9;
			this.gatewayEuiButton.UseVisualStyleBackColor = true;
			this.gatewayEuiButton.Click += new System.EventHandler(this.gatewayEuiButton_Click);
			// 
			// deviceEuiButton
			// 
			this.deviceEuiButton.BackgroundImage = global::HL7Creator.Properties.Resources.repeat32;
			this.deviceEuiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.deviceEuiButton.Location = new System.Drawing.Point(217, 48);
			this.deviceEuiButton.Name = "deviceEuiButton";
			this.deviceEuiButton.Size = new System.Drawing.Size(20, 20);
			this.deviceEuiButton.TabIndex = 6;
			this.deviceEuiButton.UseVisualStyleBackColor = true;
			this.deviceEuiButton.Click += new System.EventHandler(this.deviceEuiButton_Click);
			// 
			// textConstantsCheck
			// 
			this.textConstantsCheck.AutoSize = true;
			this.textConstantsCheck.Checked = true;
			this.textConstantsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.textConstantsCheck.Location = new System.Drawing.Point(9, 74);
			this.textConstantsCheck.Name = "textConstantsCheck";
			this.textConstantsCheck.Size = new System.Drawing.Size(96, 17);
			this.textConstantsCheck.TabIndex = 10;
			this.textConstantsCheck.Text = "Text constants";
			this.textConstantsCheck.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(254, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Gateway EUI";
			// 
			// gatewayEuiText
			// 
			this.gatewayEuiText.Location = new System.Drawing.Point(339, 45);
			this.gatewayEuiText.Name = "gatewayEuiText";
			this.gatewayEuiText.Size = new System.Drawing.Size(120, 20);
			this.gatewayEuiText.TabIndex = 8;
			this.gatewayEuiText.Text = "0000000000000000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(254, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Gateway Name";
			// 
			// gatewayNameText
			// 
			this.gatewayNameText.Location = new System.Drawing.Point(339, 19);
			this.gatewayNameText.Name = "gatewayNameText";
			this.gatewayNameText.Size = new System.Drawing.Size(146, 20);
			this.gatewayNameText.TabIndex = 3;
			this.gatewayNameText.Text = "HL7Creator";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Device EUI";
			// 
			// deviceEuiText
			// 
			this.deviceEuiText.Location = new System.Drawing.Point(91, 48);
			this.deviceEuiText.Name = "deviceEuiText";
			this.deviceEuiText.Size = new System.Drawing.Size(120, 20);
			this.deviceEuiText.TabIndex = 5;
			this.deviceEuiText.Text = "0000000000000000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Device Type";
			// 
			// deviceTypeCombo
			// 
			this.deviceTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.deviceTypeCombo.FormattingEnabled = true;
			this.deviceTypeCombo.Location = new System.Drawing.Point(91, 19);
			this.deviceTypeCombo.Name = "deviceTypeCombo";
			this.deviceTypeCombo.Size = new System.Drawing.Size(146, 21);
			this.deviceTypeCombo.TabIndex = 1;
			this.deviceTypeCombo.SelectedIndexChanged += new System.EventHandler(this.deviceTypeCombo_SelectedIndexChanged);
			// 
			// hl7Group
			// 
			this.hl7Group.Controls.Add(this.hl7Text);
			this.hl7Group.Controls.Add(this.label1);
			this.hl7Group.Controls.Add(this.lengthText);
			this.hl7Group.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hl7Group.Location = new System.Drawing.Point(0, 205);
			this.hl7Group.Name = "hl7Group";
			this.hl7Group.Size = new System.Drawing.Size(584, 218);
			this.hl7Group.TabIndex = 2;
			this.hl7Group.TabStop = false;
			this.hl7Group.Text = "HL7";
			// 
			// obsGroup
			// 
			this.obsGroup.Controls.Add(this.obsOffsetMinsText);
			this.obsGroup.Controls.Add(this.obsOffsetHoursText);
			this.obsGroup.Controls.Add(this.label9);
			this.obsGroup.Controls.Add(this.obsOffsetSignCombo);
			this.obsGroup.Controls.Add(this.label8);
			this.obsGroup.Controls.Add(this.clearObsButton);
			this.obsGroup.Controls.Add(this.removeObsButton);
			this.obsGroup.Controls.Add(this.addObsButton);
			this.obsGroup.Controls.Add(this.label7);
			this.obsGroup.Controls.Add(this.obsTypeCombo);
			this.obsGroup.Controls.Add(this.obsListView);
			this.obsGroup.Controls.Add(this.obsDateTime);
			this.obsGroup.Controls.Add(this.label11);
			this.obsGroup.Controls.Add(this.label10);
			this.obsGroup.Controls.Add(this.obsUnitsCombo);
			this.obsGroup.Controls.Add(this.obsValueText);
			this.obsGroup.Controls.Add(this.label6);
			this.obsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.obsGroup.Location = new System.Drawing.Point(0, 0);
			this.obsGroup.MinimumSize = new System.Drawing.Size(0, 197);
			this.obsGroup.Name = "obsGroup";
			this.obsGroup.Size = new System.Drawing.Size(584, 197);
			this.obsGroup.TabIndex = 0;
			this.obsGroup.TabStop = false;
			this.obsGroup.Text = "Observations";
			// 
			// obsOffsetMinsText
			// 
			this.obsOffsetMinsText.Location = new System.Drawing.Point(163, 45);
			this.obsOffsetMinsText.Name = "obsOffsetMinsText";
			this.obsOffsetMinsText.Size = new System.Drawing.Size(20, 20);
			this.obsOffsetMinsText.TabIndex = 6;
			this.obsOffsetMinsText.Text = "00";
			// 
			// obsOffsetHoursText
			// 
			this.obsOffsetHoursText.Location = new System.Drawing.Point(127, 45);
			this.obsOffsetHoursText.Name = "obsOffsetHoursText";
			this.obsOffsetHoursText.Size = new System.Drawing.Size(20, 20);
			this.obsOffsetHoursText.TabIndex = 4;
			this.obsOffsetHoursText.Text = "00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(150, 48);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(10, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = ":";
			// 
			// obsOffsetSignCombo
			// 
			this.obsOffsetSignCombo.FormattingEnabled = true;
			this.obsOffsetSignCombo.Items.AddRange(new object[] {
            "+",
            "-"});
			this.obsOffsetSignCombo.Location = new System.Drawing.Point(91, 45);
			this.obsOffsetSignCombo.Name = "obsOffsetSignCombo";
			this.obsOffsetSignCombo.Size = new System.Drawing.Size(30, 21);
			this.obsOffsetSignCombo.TabIndex = 3;
			this.obsOffsetSignCombo.Text = "+";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Time offset [h:m]";
			// 
			// clearObsButton
			// 
			this.clearObsButton.Image = global::HL7Creator.Properties.Resources.cross_32;
			this.clearObsButton.Location = new System.Drawing.Point(197, 150);
			this.clearObsButton.Name = "clearObsButton";
			this.clearObsButton.Size = new System.Drawing.Size(40, 40);
			this.clearObsButton.TabIndex = 15;
			this.clearObsButton.UseVisualStyleBackColor = true;
			this.clearObsButton.Click += new System.EventHandler(this.clearObsButton_Click);
			// 
			// removeObsButton
			// 
			this.removeObsButton.Image = global::HL7Creator.Properties.Resources.minus_32;
			this.removeObsButton.Location = new System.Drawing.Point(137, 151);
			this.removeObsButton.Name = "removeObsButton";
			this.removeObsButton.Size = new System.Drawing.Size(40, 40);
			this.removeObsButton.TabIndex = 14;
			this.removeObsButton.UseVisualStyleBackColor = true;
			this.removeObsButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// addObsButton
			// 
			this.addObsButton.Image = global::HL7Creator.Properties.Resources.plus_32;
			this.addObsButton.Location = new System.Drawing.Point(91, 151);
			this.addObsButton.Name = "addObsButton";
			this.addObsButton.Size = new System.Drawing.Size(40, 40);
			this.addObsButton.TabIndex = 13;
			this.addObsButton.UseVisualStyleBackColor = true;
			this.addObsButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Type";
			// 
			// obsTypeCombo
			// 
			this.obsTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.obsTypeCombo.FormattingEnabled = true;
			this.obsTypeCombo.Location = new System.Drawing.Point(91, 71);
			this.obsTypeCombo.Name = "obsTypeCombo";
			this.obsTypeCombo.Size = new System.Drawing.Size(146, 21);
			this.obsTypeCombo.TabIndex = 8;
			this.obsTypeCombo.SelectedIndexChanged += new System.EventHandler(this.obsTypeCombo_SelectedIndexChanged);
			// 
			// obsListView
			// 
			this.obsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.obsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimestampColumnHeader,
            this.typeColumnHeader,
            this.valueColumnHeader,
            this.unitsColumnHeader});
			this.obsListView.ContextMenuStrip = this.contextMenu;
			this.obsListView.FullRowSelect = true;
			this.obsListView.Location = new System.Drawing.Point(257, 19);
			this.obsListView.Name = "obsListView";
			this.obsListView.Size = new System.Drawing.Size(321, 171);
			this.obsListView.TabIndex = 16;
			this.obsListView.UseCompatibleStateImageBehavior = false;
			this.obsListView.View = System.Windows.Forms.View.Details;
			// 
			// TimestampColumnHeader
			// 
			this.TimestampColumnHeader.Text = "Time stamp";
			this.TimestampColumnHeader.Width = 150;
			// 
			// typeColumnHeader
			// 
			this.typeColumnHeader.Text = "Type";
			this.typeColumnHeader.Width = 65;
			// 
			// valueColumnHeader
			// 
			this.valueColumnHeader.Text = "Value";
			this.valueColumnHeader.Width = 40;
			// 
			// unitsColumnHeader
			// 
			this.unitsColumnHeader.Text = "Units";
			// 
			// obsDateTime
			// 
			this.obsDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
			this.obsDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.obsDateTime.Location = new System.Drawing.Point(91, 19);
			this.obsDateTime.Name = "obsDateTime";
			this.obsDateTime.Size = new System.Drawing.Size(146, 20);
			this.obsDateTime.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Time stamp";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Units";
			// 
			// obsUnitsCombo
			// 
			this.obsUnitsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.obsUnitsCombo.FormattingEnabled = true;
			this.obsUnitsCombo.Location = new System.Drawing.Point(91, 124);
			this.obsUnitsCombo.Name = "obsUnitsCombo";
			this.obsUnitsCombo.Size = new System.Drawing.Size(146, 21);
			this.obsUnitsCombo.TabIndex = 12;
			// 
			// obsValueText
			// 
			this.obsValueText.Location = new System.Drawing.Point(91, 98);
			this.obsValueText.Name = "obsValueText";
			this.obsValueText.Size = new System.Drawing.Size(146, 20);
			this.obsValueText.TabIndex = 10;
			this.obsValueText.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Value";
			// 
			// menuToolStrip
			// 
			this.menuToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createButton,
            this.saveAsButton,
            this.clearButton,
            this.wrapButton,
            this.aboutButton});
			this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
			this.menuToolStrip.Name = "menuToolStrip";
			this.menuToolStrip.Size = new System.Drawing.Size(584, 39);
			this.menuToolStrip.TabIndex = 0;
			// 
			// createButton
			// 
			this.createButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.createButton.Image = global::HL7Creator.Properties.Resources.play_32;
			this.createButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(36, 36);
			this.createButton.Text = "Create";
			this.createButton.ToolTipText = "createButton";
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// saveAsButton
			// 
			this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
			this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(36, 36);
			this.saveAsButton.Text = "Save As";
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
			this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(36, 36);
			this.clearButton.Text = "Clear";
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// wrapButton
			// 
			this.wrapButton.CheckOnClick = true;
			this.wrapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.wrapButton.Image = ((System.Drawing.Image)(resources.GetObject("wrapButton.Image")));
			this.wrapButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.wrapButton.Name = "wrapButton";
			this.wrapButton.Size = new System.Drawing.Size(36, 36);
			this.wrapButton.Text = "Wrap";
			this.wrapButton.Click += new System.EventHandler(this.wrapButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(36, 36);
			this.aboutButton.Text = "About";
			this.aboutButton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPanel.Controls.Add(this.hl7Group);
			this.mainPanel.Controls.Add(this.splitter);
			this.mainPanel.Controls.Add(this.obsGroup);
			this.mainPanel.Location = new System.Drawing.Point(0, 139);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(584, 423);
			this.mainPanel.TabIndex = 5;
			// 
			// splitter
			// 
			this.splitter.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter.Location = new System.Drawing.Point(0, 197);
			this.splitter.MinExtra = 100;
			this.splitter.MinSize = 197;
			this.splitter.Name = "splitter";
			this.splitter.Size = new System.Drawing.Size(584, 8);
			this.splitter.TabIndex = 1;
			this.splitter.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 562);
			this.Controls.Add(this.menuToolStrip);
			this.Controls.Add(this.generalGroup);
			this.Controls.Add(this.mainPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(509, 500);
			this.Name = "MainForm";
			this.Text = "HL7 Creator";
			this.contextMenu.ResumeLayout(false);
			this.generalGroup.ResumeLayout(false);
			this.generalGroup.PerformLayout();
			this.hl7Group.ResumeLayout(false);
			this.hl7Group.PerformLayout();
			this.obsGroup.ResumeLayout(false);
			this.obsGroup.PerformLayout();
			this.menuToolStrip.ResumeLayout(false);
			this.menuToolStrip.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox hl7Text;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox lengthText;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.GroupBox generalGroup;
		private System.Windows.Forms.GroupBox hl7Group;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox deviceTypeCombo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox deviceEuiText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox gatewayNameText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox gatewayEuiText;
		private System.Windows.Forms.GroupBox obsGroup;
		private System.Windows.Forms.DateTimePicker obsDateTime;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox obsUnitsCombo;
		private System.Windows.Forms.TextBox obsValueText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListView obsListView;
		private System.Windows.Forms.ColumnHeader typeColumnHeader;
		private System.Windows.Forms.ColumnHeader TimestampColumnHeader;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox obsTypeCombo;
		private System.Windows.Forms.Button removeObsButton;
		private System.Windows.Forms.Button addObsButton;
		private System.Windows.Forms.ColumnHeader valueColumnHeader;
		private System.Windows.Forms.ColumnHeader unitsColumnHeader;
		private System.Windows.Forms.CheckBox textConstantsCheck;
		private System.Windows.Forms.Button deviceEuiButton;
		private System.Windows.Forms.Button gatewayEuiButton;
		private System.Windows.Forms.CheckBox timeSyncCheck;
		private System.Windows.Forms.ToolStrip menuToolStrip;
		private System.Windows.Forms.ToolStripButton createButton;
		private System.Windows.Forms.ToolStripButton clearButton;
		private System.Windows.Forms.ToolStripButton wrapButton;
		private System.Windows.Forms.ToolStripButton aboutButton;
		private System.Windows.Forms.Button clearObsButton;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox obsOffsetSignCombo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox obsOffsetMinsText;
		private System.Windows.Forms.TextBox obsOffsetHoursText;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Splitter splitter;
		private System.Windows.Forms.ToolStripButton saveAsButton;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
	}
}


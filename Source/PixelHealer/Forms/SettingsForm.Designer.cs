namespace PixelHealer
{
    partial class SettingsForm
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
            this.autoCloseElapsedLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.toggleFlashingButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.colorsLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pickCustomColorButton = new System.Windows.Forms.Button();
            this.autoCloseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.topNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.locateButton = new System.Windows.Forms.Button();
            this.colorsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.blackCheckBox = new System.Windows.Forms.CheckBox();
            this.whiteCheckBox = new System.Windows.Forms.CheckBox();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.customColorCheckBox = new System.Windows.Forms.CheckBox();
            this.contentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.windowPositionSizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.windowPositionSizeLabel = new System.Windows.Forms.Label();
            this.windowAlwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.intervalTrackBar = new System.Windows.Forms.TrackBar();
            this.autoCloseLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.autoCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.sidebarFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.leftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.colorsFlowLayoutPanel.SuspendLayout();
            this.contentFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.windowPositionSizeFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).BeginInit();
            this.autoCloseLayoutPanel.SuspendLayout();
            this.sidebarFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoCloseElapsedLabel
            // 
            this.autoCloseElapsedLabel.AutoSize = true;
            this.autoCloseElapsedLabel.ForeColor = System.Drawing.Color.White;
            this.autoCloseElapsedLabel.Location = new System.Drawing.Point(116, 39);
            this.autoCloseElapsedLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.autoCloseElapsedLabel.Name = "autoCloseElapsedLabel";
            this.autoCloseElapsedLabel.Size = new System.Drawing.Size(48, 13);
            this.autoCloseElapsedLabel.TabIndex = 2;
            this.autoCloseElapsedLabel.Text = "Elapsed:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(0, 62);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(143, 52);
            this.warningLabel.TabIndex = 1;
            this.warningLabel.Text = "EPILEPSY WARNING: Flashing colors can trigger epilepsy attacks. Don\'t stare at th" +
    "e PixelHealer window!";
            // 
            // toggleFlashingButton
            // 
            this.toggleFlashingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleFlashingButton.ForeColor = System.Drawing.Color.White;
            this.toggleFlashingButton.Location = new System.Drawing.Point(0, 134);
            this.toggleFlashingButton.Margin = new System.Windows.Forms.Padding(0);
            this.toggleFlashingButton.Name = "toggleFlashingButton";
            this.toggleFlashingButton.Size = new System.Drawing.Size(120, 32);
            this.toggleFlashingButton.TabIndex = 2;
            this.toggleFlashingButton.UseVisualStyleBackColor = false;
            this.toggleFlashingButton.Click += new System.EventHandler(this.ToggleFlashingButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.ForeColor = System.Drawing.Color.White;
            this.intervalLabel.Location = new System.Drawing.Point(20, 10);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(89, 13);
            this.intervalLabel.TabIndex = 0;
            this.intervalLabel.Text = "Flash every 10ms";
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.ForeColor = System.Drawing.Color.White;
            this.introLabel.Location = new System.Drawing.Point(0, 0);
            this.introLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(150, 52);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "To try to revive a dead pixel, cover it with the color window, click Start Flashi" +
    "ng, and let it run for a while.";
            // 
            // colorsLabel
            // 
            this.colorsLabel.AutoSize = true;
            this.colorsLabel.ForeColor = System.Drawing.Color.White;
            this.colorsLabel.Location = new System.Drawing.Point(20, 10);
            this.colorsLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.colorsLabel.Name = "colorsLabel";
            this.colorsLabel.Size = new System.Drawing.Size(77, 13);
            this.colorsLabel.TabIndex = 0;
            this.colorsLabel.Text = "Flashing colors";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // pickCustomColorButton
            // 
            this.pickCustomColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pickCustomColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickCustomColorButton.ForeColor = System.Drawing.Color.White;
            this.pickCustomColorButton.Location = new System.Drawing.Point(259, 13);
            this.pickCustomColorButton.Name = "pickCustomColorButton";
            this.pickCustomColorButton.Size = new System.Drawing.Size(65, 34);
            this.pickCustomColorButton.TabIndex = 6;
            this.pickCustomColorButton.Text = "Pick...";
            this.toolTip.SetToolTip(this.pickCustomColorButton, "Pick custom color");
            this.pickCustomColorButton.UseVisualStyleBackColor = false;
            this.pickCustomColorButton.Click += new System.EventHandler(this.PickCustomColorButton_Click);
            // 
            // autoCloseDateTimePicker
            // 
            this.autoCloseDateTimePicker.CustomFormat = "HH:mm:ss";
            this.autoCloseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PixelHealer.Properties.Settings.Default, "AutoCloseTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoCloseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.autoCloseDateTimePicker.Location = new System.Drawing.Point(20, 37);
            this.autoCloseDateTimePicker.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.autoCloseDateTimePicker.Name = "autoCloseDateTimePicker";
            this.autoCloseDateTimePicker.ShowUpDown = true;
            this.autoCloseDateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.autoCloseDateTimePicker.TabIndex = 1;
            this.toolTip.SetToolTip(this.autoCloseDateTimePicker, "Including the elapsed time so far");
            this.autoCloseDateTimePicker.Value = global::PixelHealer.Properties.Settings.Default.AutoCloseTime;
            // 
            // leftNumericUpDown
            // 
            this.leftNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.leftNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PixelHealer.Properties.Settings.Default, "Left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.leftNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.leftNumericUpDown.Location = new System.Drawing.Point(20, 33);
            this.leftNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.leftNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.leftNumericUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.leftNumericUpDown.Name = "leftNumericUpDown";
            this.leftNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.leftNumericUpDown.TabIndex = 1;
            this.toolTip.SetToolTip(this.leftNumericUpDown, "Left");
            this.leftNumericUpDown.Value = global::PixelHealer.Properties.Settings.Default.Left;
            // 
            // topNumericUpDown
            // 
            this.topNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.topNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PixelHealer.Properties.Settings.Default, "Top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.topNumericUpDown.Location = new System.Drawing.Point(76, 33);
            this.topNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.topNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.topNumericUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.topNumericUpDown.Name = "topNumericUpDown";
            this.topNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.topNumericUpDown.TabIndex = 2;
            this.toolTip.SetToolTip(this.topNumericUpDown, "Top");
            this.topNumericUpDown.Value = global::PixelHealer.Properties.Settings.Default.Top;
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.widthNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PixelHealer.Properties.Settings.Default, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.widthNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.widthNumericUpDown.Location = new System.Drawing.Point(132, 33);
            this.widthNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.widthNumericUpDown.TabIndex = 3;
            this.toolTip.SetToolTip(this.widthNumericUpDown, "Width");
            this.widthNumericUpDown.Value = global::PixelHealer.Properties.Settings.Default.Width;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.heightNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PixelHealer.Properties.Settings.Default, "Height", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.heightNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.heightNumericUpDown.Location = new System.Drawing.Point(188, 33);
            this.heightNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.heightNumericUpDown.TabIndex = 4;
            this.toolTip.SetToolTip(this.heightNumericUpDown, "Height");
            this.heightNumericUpDown.Value = global::PixelHealer.Properties.Settings.Default.Height;
            // 
            // locateButton
            // 
            this.locateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowPositionSizeFlowLayoutPanel.SetFlowBreak(this.locateButton, true);
            this.locateButton.ForeColor = System.Drawing.Color.White;
            this.locateButton.Location = new System.Drawing.Point(244, 33);
            this.locateButton.Margin = new System.Windows.Forms.Padding(0);
            this.locateButton.Name = "locateButton";
            this.locateButton.Size = new System.Drawing.Size(60, 20);
            this.locateButton.TabIndex = 5;
            this.locateButton.Text = "Locate";
            this.toolTip.SetToolTip(this.locateButton, "Locate on screen");
            this.locateButton.UseVisualStyleBackColor = false;
            this.locateButton.Click += new System.EventHandler(this.LocateButton_Click);
            // 
            // colorsFlowLayoutPanel
            // 
            this.colorsFlowLayoutPanel.AutoSize = true;
            this.colorsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorsFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.colorsFlowLayoutPanel.Controls.Add(this.blackCheckBox);
            this.colorsFlowLayoutPanel.Controls.Add(this.whiteCheckBox);
            this.colorsFlowLayoutPanel.Controls.Add(this.redCheckBox);
            this.colorsFlowLayoutPanel.Controls.Add(this.greenCheckBox);
            this.colorsFlowLayoutPanel.Controls.Add(this.blueCheckBox);
            this.colorsFlowLayoutPanel.Controls.Add(this.customColorCheckBox);
            this.colorsFlowLayoutPanel.Controls.Add(this.pickCustomColorButton);
            this.colorsFlowLayoutPanel.Location = new System.Drawing.Point(20, 33);
            this.colorsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.colorsFlowLayoutPanel.Name = "colorsFlowLayoutPanel";
            this.colorsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.colorsFlowLayoutPanel.Size = new System.Drawing.Size(337, 60);
            this.colorsFlowLayoutPanel.TabIndex = 1;
            // 
            // blackCheckBox
            // 
            this.blackCheckBox.AutoSize = true;
            this.blackCheckBox.BackColor = System.Drawing.Color.Black;
            this.blackCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.BlackChecked;
            this.blackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blackCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "BlackChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.blackCheckBox.ForeColor = System.Drawing.Color.White;
            this.blackCheckBox.Location = new System.Drawing.Point(13, 13);
            this.blackCheckBox.Name = "blackCheckBox";
            this.blackCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.blackCheckBox.Size = new System.Drawing.Size(35, 34);
            this.blackCheckBox.TabIndex = 0;
            this.blackCheckBox.UseVisualStyleBackColor = false;
            // 
            // whiteCheckBox
            // 
            this.whiteCheckBox.AutoSize = true;
            this.whiteCheckBox.BackColor = System.Drawing.Color.White;
            this.whiteCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.WhiteChecked;
            this.whiteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.whiteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "WhiteChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.whiteCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.whiteCheckBox.ForeColor = System.Drawing.Color.White;
            this.whiteCheckBox.Location = new System.Drawing.Point(54, 13);
            this.whiteCheckBox.Name = "whiteCheckBox";
            this.whiteCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.whiteCheckBox.Size = new System.Drawing.Size(35, 34);
            this.whiteCheckBox.TabIndex = 1;
            this.whiteCheckBox.UseVisualStyleBackColor = false;
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.BackColor = System.Drawing.Color.Red;
            this.redCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.RedChecked;
            this.redCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "RedChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.redCheckBox.ForeColor = System.Drawing.Color.White;
            this.redCheckBox.Location = new System.Drawing.Point(95, 13);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.redCheckBox.Size = new System.Drawing.Size(35, 34);
            this.redCheckBox.TabIndex = 2;
            this.redCheckBox.UseVisualStyleBackColor = false;
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.BackColor = System.Drawing.Color.Lime;
            this.greenCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.GreenChecked;
            this.greenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "GreenChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.greenCheckBox.ForeColor = System.Drawing.Color.White;
            this.greenCheckBox.Location = new System.Drawing.Point(136, 13);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.greenCheckBox.Size = new System.Drawing.Size(35, 34);
            this.greenCheckBox.TabIndex = 3;
            this.greenCheckBox.UseVisualStyleBackColor = false;
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.BackColor = System.Drawing.Color.Blue;
            this.blueCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.BlueChecked;
            this.blueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "BlueChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.blueCheckBox.ForeColor = System.Drawing.Color.White;
            this.blueCheckBox.Location = new System.Drawing.Point(177, 13);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.blueCheckBox.Size = new System.Drawing.Size(35, 34);
            this.blueCheckBox.TabIndex = 4;
            this.blueCheckBox.UseVisualStyleBackColor = false;
            // 
            // customColorCheckBox
            // 
            this.customColorCheckBox.AutoSize = true;
            this.customColorCheckBox.BackColor = global::PixelHealer.Properties.Settings.Default.CustomColor;
            this.customColorCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.CustomColorChecked;
            this.customColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customColorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "CustomColorChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customColorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::PixelHealer.Properties.Settings.Default, "CustomColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customColorCheckBox.ForeColor = System.Drawing.Color.White;
            this.customColorCheckBox.Location = new System.Drawing.Point(218, 13);
            this.customColorCheckBox.Name = "customColorCheckBox";
            this.customColorCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.customColorCheckBox.Size = new System.Drawing.Size(35, 34);
            this.customColorCheckBox.TabIndex = 5;
            this.customColorCheckBox.UseVisualStyleBackColor = false;
            // 
            // contentFlowLayoutPanel
            // 
            this.contentFlowLayoutPanel.AutoSize = true;
            this.contentFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentFlowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.contentFlowLayoutPanel.Controls.Add(this.windowPositionSizeFlowLayoutPanel);
            this.contentFlowLayoutPanel.Controls.Add(this.flowLayoutPanel2);
            this.contentFlowLayoutPanel.Controls.Add(this.autoCloseLayoutPanel);
            this.contentFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contentFlowLayoutPanel.Location = new System.Drawing.Point(20, 20);
            this.contentFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
            this.contentFlowLayoutPanel.Size = new System.Drawing.Size(380, 376);
            this.contentFlowLayoutPanel.TabIndex = 1;
            this.contentFlowLayoutPanel.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.colorsLabel);
            this.flowLayoutPanel1.Controls.Add(this.colorsFlowLayoutPanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(380, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // windowPositionSizeFlowLayoutPanel
            // 
            this.windowPositionSizeFlowLayoutPanel.AutoSize = true;
            this.windowPositionSizeFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowPositionSizeFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.windowPositionSizeLabel);
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.leftNumericUpDown);
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.topNumericUpDown);
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.widthNumericUpDown);
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.heightNumericUpDown);
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.locateButton);
            this.windowPositionSizeFlowLayoutPanel.Controls.Add(this.windowAlwaysOnTopCheckBox);
            this.windowPositionSizeFlowLayoutPanel.Location = new System.Drawing.Point(0, 115);
            this.windowPositionSizeFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.windowPositionSizeFlowLayoutPanel.MinimumSize = new System.Drawing.Size(380, 2);
            this.windowPositionSizeFlowLayoutPanel.Name = "windowPositionSizeFlowLayoutPanel";
            this.windowPositionSizeFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.windowPositionSizeFlowLayoutPanel.Size = new System.Drawing.Size(380, 92);
            this.windowPositionSizeFlowLayoutPanel.TabIndex = 1;
            // 
            // windowPositionSizeLabel
            // 
            this.windowPositionSizeLabel.AutoSize = true;
            this.windowPositionSizeFlowLayoutPanel.SetFlowBreak(this.windowPositionSizeLabel, true);
            this.windowPositionSizeLabel.ForeColor = System.Drawing.Color.White;
            this.windowPositionSizeLabel.Location = new System.Drawing.Point(20, 10);
            this.windowPositionSizeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.windowPositionSizeLabel.Name = "windowPositionSizeLabel";
            this.windowPositionSizeLabel.Size = new System.Drawing.Size(166, 13);
            this.windowPositionSizeLabel.TabIndex = 0;
            this.windowPositionSizeLabel.Text = "Flashing window position and size";
            // 
            // windowAlwaysOnTopCheckBox
            // 
            this.windowAlwaysOnTopCheckBox.AutoSize = true;
            this.windowAlwaysOnTopCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.AlwaysOnTop;
            this.windowAlwaysOnTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windowAlwaysOnTopCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "AlwaysOnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.windowAlwaysOnTopCheckBox.ForeColor = System.Drawing.Color.White;
            this.windowAlwaysOnTopCheckBox.Location = new System.Drawing.Point(20, 63);
            this.windowAlwaysOnTopCheckBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.windowAlwaysOnTopCheckBox.Name = "windowAlwaysOnTopCheckBox";
            this.windowAlwaysOnTopCheckBox.Size = new System.Drawing.Size(172, 17);
            this.windowAlwaysOnTopCheckBox.TabIndex = 6;
            this.windowAlwaysOnTopCheckBox.Text = "Flashing window always on top";
            this.windowAlwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.intervalLabel);
            this.flowLayoutPanel2.Controls.Add(this.intervalTrackBar);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 217);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(380, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(380, 80);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // intervalTrackBar
            // 
            this.intervalTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PixelHealer.Properties.Settings.Default, "FlashingInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.intervalTrackBar.Location = new System.Drawing.Point(20, 33);
            this.intervalTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.intervalTrackBar.Maximum = 1000;
            this.intervalTrackBar.Minimum = 1;
            this.intervalTrackBar.Name = "intervalTrackBar";
            this.intervalTrackBar.Size = new System.Drawing.Size(337, 45);
            this.intervalTrackBar.TabIndex = 1;
            this.intervalTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.intervalTrackBar.Value = global::PixelHealer.Properties.Settings.Default.FlashingInterval;
            this.intervalTrackBar.Scroll += new System.EventHandler(this.IntervalTrackBar_Scroll);
            // 
            // autoCloseLayoutPanel
            // 
            this.autoCloseLayoutPanel.AutoSize = true;
            this.autoCloseLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.autoCloseLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCloseLayoutPanel.Controls.Add(this.autoCloseCheckBox);
            this.autoCloseLayoutPanel.Controls.Add(this.autoCloseDateTimePicker);
            this.autoCloseLayoutPanel.Controls.Add(this.autoCloseElapsedLabel);
            this.autoCloseLayoutPanel.Location = new System.Drawing.Point(0, 307);
            this.autoCloseLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.autoCloseLayoutPanel.MinimumSize = new System.Drawing.Size(380, 2);
            this.autoCloseLayoutPanel.Name = "autoCloseLayoutPanel";
            this.autoCloseLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.autoCloseLayoutPanel.Size = new System.Drawing.Size(380, 69);
            this.autoCloseLayoutPanel.TabIndex = 3;
            // 
            // autoCloseCheckBox
            // 
            this.autoCloseCheckBox.AutoSize = true;
            this.autoCloseCheckBox.Checked = global::PixelHealer.Properties.Settings.Default.AutoClose;
            this.autoCloseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PixelHealer.Properties.Settings.Default, "AutoClose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoCloseLayoutPanel.SetFlowBreak(this.autoCloseCheckBox, true);
            this.autoCloseCheckBox.ForeColor = System.Drawing.Color.White;
            this.autoCloseCheckBox.Location = new System.Drawing.Point(20, 10);
            this.autoCloseCheckBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.autoCloseCheckBox.Name = "autoCloseCheckBox";
            this.autoCloseCheckBox.Size = new System.Drawing.Size(143, 17);
            this.autoCloseCheckBox.TabIndex = 0;
            this.autoCloseCheckBox.Text = "Automatically close after:";
            this.autoCloseCheckBox.UseVisualStyleBackColor = true;
            // 
            // sidebarFlowLayoutPanel
            // 
            this.sidebarFlowLayoutPanel.AutoSize = true;
            this.sidebarFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebarFlowLayoutPanel.Controls.Add(this.introLabel);
            this.sidebarFlowLayoutPanel.Controls.Add(this.warningLabel);
            this.sidebarFlowLayoutPanel.Controls.Add(this.toggleFlashingButton);
            this.sidebarFlowLayoutPanel.Location = new System.Drawing.Point(420, 20);
            this.sidebarFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarFlowLayoutPanel.MaximumSize = new System.Drawing.Size(150, 0);
            this.sidebarFlowLayoutPanel.Name = "sidebarFlowLayoutPanel";
            this.sidebarFlowLayoutPanel.Size = new System.Drawing.Size(150, 166);
            this.sidebarFlowLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.contentFlowLayoutPanel);
            this.flowLayoutPanel3.Controls.Add(this.sidebarFlowLayoutPanel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(590, 416);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(621, 441);
            this.Controls.Add(this.flowLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelHealer Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.leftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.colorsFlowLayoutPanel.ResumeLayout(false);
            this.colorsFlowLayoutPanel.PerformLayout();
            this.contentFlowLayoutPanel.ResumeLayout(false);
            this.contentFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.windowPositionSizeFlowLayoutPanel.ResumeLayout(false);
            this.windowPositionSizeFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).EndInit();
            this.autoCloseLayoutPanel.ResumeLayout(false);
            this.autoCloseLayoutPanel.PerformLayout();
            this.sidebarFlowLayoutPanel.ResumeLayout(false);
            this.sidebarFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TrackBar intervalTrackBar;
        private System.Windows.Forms.Button toggleFlashingButton;
        private System.Windows.Forms.Label colorsLabel;
        private System.Windows.Forms.CheckBox windowAlwaysOnTopCheckBox;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox autoCloseCheckBox;
        private System.Windows.Forms.DateTimePicker autoCloseDateTimePicker;
        private System.Windows.Forms.Label autoCloseElapsedLabel;
        private System.Windows.Forms.CheckBox blackCheckBox;
        private System.Windows.Forms.FlowLayoutPanel colorsFlowLayoutPanel;
        private System.Windows.Forms.CheckBox whiteCheckBox;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.CheckBox customColorCheckBox;
        private System.Windows.Forms.FlowLayoutPanel contentFlowLayoutPanel;
        private System.Windows.Forms.Button pickCustomColorButton;
        private System.Windows.Forms.FlowLayoutPanel sidebarFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel autoCloseLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel windowPositionSizeFlowLayoutPanel;
        private System.Windows.Forms.NumericUpDown leftNumericUpDown;
        private System.Windows.Forms.NumericUpDown topNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label windowPositionSizeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button locateButton;
    }
}
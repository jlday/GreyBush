namespace GreyBush
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GoButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FileOptionsTab = new System.Windows.Forms.TabPage();
            this.OnlyCloseWithClickCheckbox = new System.Windows.Forms.CheckBox();
            this.AlwaysClickButtonsCheckBox = new System.Windows.Forms.CheckBox();
            this.OKbeforeCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.HideWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.CommandLineArgsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BaseFileButton = new System.Windows.Forms.Button();
            this.BaseFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CrashDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.CrashDirectoryButton = new System.Windows.Forms.Button();
            this.TargetBrowseButton = new System.Windows.Forms.Button();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.FuzzOptionsTab = new System.Windows.Forms.TabPage();
            this.NetworkFuzzerRadio = new System.Windows.Forms.RadioButton();
            this.FileFormatRadio = new System.Windows.Forms.RadioButton();
            this.FuzzerTabControl = new System.Windows.Forms.TabControl();
            this.FileFormatTab = new System.Windows.Forms.TabPage();
            this.RandomFuzzRadio = new System.Windows.Forms.RadioButton();
            this.SequentialFuzzerRadio = new System.Windows.Forms.RadioButton();
            this.FileFormatTabControl = new System.Windows.Forms.TabControl();
            this.SequentialTab = new System.Windows.Forms.TabPage();
            this.SequentialOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SequentialFuzzModificationIncrement = new System.Windows.Forms.CheckedListBox();
            this.SequentialFuzzModificationSize = new System.Windows.Forms.CheckedListBox();
            this.SequentialFuzModificationBytes = new System.Windows.Forms.CheckedListBox();
            this.SequentialFuzzModificationOptions = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SequentialFuzzEndingOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SequentialFuzzStartingOffset = new System.Windows.Forms.TextBox();
            this.RandomFuzzTab = new System.Windows.Forms.TabPage();
            this.RandomFuzzOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RandomFuzzEndFilePercentageTextBox = new System.Windows.Forms.TextBox();
            this.RandomFuzzStartFilePercentageTextBox = new System.Windows.Forms.TextBox();
            this.RandomFuzzPermutationBytes = new System.Windows.Forms.CheckedListBox();
            this.RandomFuzzModificationOptionsCheckList = new System.Windows.Forms.CheckedListBox();
            this.RandomFuzzTotalAttemptsTextBox = new System.Windows.Forms.TextBox();
            this.RandomFuzzTotalAttemptsLabel = new System.Windows.Forms.Label();
            this.RandomFuzzSprayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NetworkFuzzerTab = new System.Windows.Forms.TabPage();
            this.PcapRandomFuzzRadio = new System.Windows.Forms.RadioButton();
            this.NetworkFuzzerTabControl = new System.Windows.Forms.TabControl();
            this.PcapStringFuzzTab = new System.Windows.Forms.TabPage();
            this.PcapRandomFuzzTab = new System.Windows.Forms.TabPage();
            this.PcapRandomFuzzGroupBox = new System.Windows.Forms.GroupBox();
            this.DebuggerOptionsTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IgnoreExceptionsCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MoveAllIgnoreButton = new System.Windows.Forms.Button();
            this.SingleToIgnoreButton = new System.Windows.Forms.Button();
            this.MoveAllRecordButton = new System.Windows.Forms.Button();
            this.SingleToRecordButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FilterErrorCodesTextBox = new System.Windows.Forms.TextBox();
            this.RecordedExceptoinsListBox = new System.Windows.Forms.ListBox();
            this.IgnoredListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HideDebuggerCheckBox = new System.Windows.Forms.CheckBox();
            this.WaitForFullStartupCheckbox = new System.Windows.Forms.CheckBox();
            this.ProcessThresholdTextBox = new System.Windows.Forms.TextBox();
            this.ProcessThresholdCheckbox = new System.Windows.Forms.CheckBox();
            this.KillAlsoCheckBox = new System.Windows.Forms.CheckBox();
            this.KillAlsoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EventTimeoutTextbox = new System.Windows.Forms.TextBox();
            this.GeneralTimeoutTextbox = new System.Windows.Forms.TextBox();
            this.EventTimeoutCheckbox = new System.Windows.Forms.CheckBox();
            this.TimeoutEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.SummaryTab = new System.Windows.Forms.TabPage();
            this.SummaryBox = new System.Windows.Forms.TextBox();
            this.DetailsTab = new System.Windows.Forms.TabPage();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.FileOptionsTab.SuspendLayout();
            this.FuzzOptionsTab.SuspendLayout();
            this.FuzzerTabControl.SuspendLayout();
            this.FileFormatTab.SuspendLayout();
            this.FileFormatTabControl.SuspendLayout();
            this.SequentialTab.SuspendLayout();
            this.SequentialOptionsGroupBox.SuspendLayout();
            this.RandomFuzzTab.SuspendLayout();
            this.RandomFuzzOptionsGroupBox.SuspendLayout();
            this.NetworkFuzzerTab.SuspendLayout();
            this.NetworkFuzzerTabControl.SuspendLayout();
            this.PcapRandomFuzzTab.SuspendLayout();
            this.DebuggerOptionsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SummaryTab.SuspendLayout();
            this.DetailsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 534);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(556, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(574, 534);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(655, 534);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FileOptionsTab);
            this.tabControl1.Controls.Add(this.FuzzOptionsTab);
            this.tabControl1.Controls.Add(this.DebuggerOptionsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 516);
            this.tabControl1.TabIndex = 3;
            // 
            // FileOptionsTab
            // 
            this.FileOptionsTab.Controls.Add(this.OnlyCloseWithClickCheckbox);
            this.FileOptionsTab.Controls.Add(this.AlwaysClickButtonsCheckBox);
            this.FileOptionsTab.Controls.Add(this.OKbeforeCloseCheckBox);
            this.FileOptionsTab.Controls.Add(this.AutoCloseCheckBox);
            this.FileOptionsTab.Controls.Add(this.HideWindowCheckBox);
            this.FileOptionsTab.Controls.Add(this.CommandLineArgsTextBox);
            this.FileOptionsTab.Controls.Add(this.label4);
            this.FileOptionsTab.Controls.Add(this.BaseFileButton);
            this.FileOptionsTab.Controls.Add(this.BaseFileTextBox);
            this.FileOptionsTab.Controls.Add(this.label3);
            this.FileOptionsTab.Controls.Add(this.label2);
            this.FileOptionsTab.Controls.Add(this.label1);
            this.FileOptionsTab.Controls.Add(this.CrashDirectoryTextBox);
            this.FileOptionsTab.Controls.Add(this.CrashDirectoryButton);
            this.FileOptionsTab.Controls.Add(this.TargetBrowseButton);
            this.FileOptionsTab.Controls.Add(this.TargetTextBox);
            this.FileOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.FileOptionsTab.Name = "FileOptionsTab";
            this.FileOptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileOptionsTab.Size = new System.Drawing.Size(329, 490);
            this.FileOptionsTab.TabIndex = 0;
            this.FileOptionsTab.Text = "File & Application Options";
            this.FileOptionsTab.UseVisualStyleBackColor = true;
            // 
            // OnlyCloseWithClickCheckbox
            // 
            this.OnlyCloseWithClickCheckbox.AutoSize = true;
            this.OnlyCloseWithClickCheckbox.Location = new System.Drawing.Point(37, 290);
            this.OnlyCloseWithClickCheckbox.Name = "OnlyCloseWithClickCheckbox";
            this.OnlyCloseWithClickCheckbox.Size = new System.Drawing.Size(218, 17);
            this.OnlyCloseWithClickCheckbox.TabIndex = 15;
            this.OnlyCloseWithClickCheckbox.Text = "Only Close a Window with a Button Click";
            this.OnlyCloseWithClickCheckbox.UseVisualStyleBackColor = true;
            // 
            // AlwaysClickButtonsCheckBox
            // 
            this.AlwaysClickButtonsCheckBox.AutoSize = true;
            this.AlwaysClickButtonsCheckBox.Enabled = false;
            this.AlwaysClickButtonsCheckBox.Location = new System.Drawing.Point(37, 313);
            this.AlwaysClickButtonsCheckBox.Name = "AlwaysClickButtonsCheckBox";
            this.AlwaysClickButtonsCheckBox.Size = new System.Drawing.Size(286, 17);
            this.AlwaysClickButtonsCheckBox.TabIndex = 14;
            this.AlwaysClickButtonsCheckBox.Text = "Always try to click these buttons, even on main window";
            this.AlwaysClickButtonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OKbeforeCloseCheckBox
            // 
            this.OKbeforeCloseCheckBox.AutoSize = true;
            this.OKbeforeCloseCheckBox.Enabled = false;
            this.OKbeforeCloseCheckBox.Location = new System.Drawing.Point(19, 267);
            this.OKbeforeCloseCheckBox.Name = "OKbeforeCloseCheckBox";
            this.OKbeforeCloseCheckBox.Size = new System.Drawing.Size(259, 17);
            this.OKbeforeCloseCheckBox.TabIndex = 13;
            this.OKbeforeCloseCheckBox.Text = "Default \'OK\', \'CONTINUE\', \'TRY\', \'NEXT\' or \'YES\'";
            this.OKbeforeCloseCheckBox.UseVisualStyleBackColor = true;
            this.OKbeforeCloseCheckBox.CheckedChanged += new System.EventHandler(this.OKbeforeCloseCheckBox_CheckedChanged);
            // 
            // AutoCloseCheckBox
            // 
            this.AutoCloseCheckBox.AutoSize = true;
            this.AutoCloseCheckBox.Location = new System.Drawing.Point(5, 244);
            this.AutoCloseCheckBox.Name = "AutoCloseCheckBox";
            this.AutoCloseCheckBox.Size = new System.Drawing.Size(172, 17);
            this.AutoCloseCheckBox.TabIndex = 12;
            this.AutoCloseCheckBox.Text = "Auto-Close Spawned Windows";
            this.AutoCloseCheckBox.UseVisualStyleBackColor = true;
            this.AutoCloseCheckBox.CheckedChanged += new System.EventHandler(this.AutoCloseCheckBox_CheckedChanged);
            // 
            // HideWindowCheckBox
            // 
            this.HideWindowCheckBox.AutoSize = true;
            this.HideWindowCheckBox.Location = new System.Drawing.Point(5, 221);
            this.HideWindowCheckBox.Name = "HideWindowCheckBox";
            this.HideWindowCheckBox.Size = new System.Drawing.Size(143, 17);
            this.HideWindowCheckBox.TabIndex = 11;
            this.HideWindowCheckBox.Text = "Hide Debuggee Window";
            this.HideWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // CommandLineArgsTextBox
            // 
            this.CommandLineArgsTextBox.Location = new System.Drawing.Point(6, 73);
            this.CommandLineArgsTextBox.Name = "CommandLineArgsTextBox";
            this.CommandLineArgsTextBox.Size = new System.Drawing.Size(317, 20);
            this.CommandLineArgsTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Command Line Options";
            // 
            // BaseFileButton
            // 
            this.BaseFileButton.Location = new System.Drawing.Point(248, 192);
            this.BaseFileButton.Name = "BaseFileButton";
            this.BaseFileButton.Size = new System.Drawing.Size(71, 23);
            this.BaseFileButton.TabIndex = 8;
            this.BaseFileButton.Text = "Browse";
            this.BaseFileButton.UseVisualStyleBackColor = true;
            this.BaseFileButton.Click += new System.EventHandler(this.BaseFileButton_Click);
            // 
            // BaseFileTextBox
            // 
            this.BaseFileTextBox.Location = new System.Drawing.Point(2, 195);
            this.BaseFileTextBox.Name = "BaseFileTextBox";
            this.BaseFileTextBox.Size = new System.Drawing.Size(240, 20);
            this.BaseFileTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crash Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Application";
            // 
            // CrashDirectoryTextBox
            // 
            this.CrashDirectoryTextBox.Location = new System.Drawing.Point(2, 156);
            this.CrashDirectoryTextBox.Name = "CrashDirectoryTextBox";
            this.CrashDirectoryTextBox.Size = new System.Drawing.Size(240, 20);
            this.CrashDirectoryTextBox.TabIndex = 3;
            // 
            // CrashDirectoryButton
            // 
            this.CrashDirectoryButton.Location = new System.Drawing.Point(248, 156);
            this.CrashDirectoryButton.Name = "CrashDirectoryButton";
            this.CrashDirectoryButton.Size = new System.Drawing.Size(71, 23);
            this.CrashDirectoryButton.TabIndex = 2;
            this.CrashDirectoryButton.Text = "Browse";
            this.CrashDirectoryButton.UseVisualStyleBackColor = true;
            this.CrashDirectoryButton.Click += new System.EventHandler(this.CrashDirectoryButton_Click);
            // 
            // TargetBrowseButton
            // 
            this.TargetBrowseButton.Location = new System.Drawing.Point(248, 31);
            this.TargetBrowseButton.Name = "TargetBrowseButton";
            this.TargetBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.TargetBrowseButton.TabIndex = 1;
            this.TargetBrowseButton.Text = "Browse";
            this.TargetBrowseButton.UseVisualStyleBackColor = true;
            this.TargetBrowseButton.Click += new System.EventHandler(this.TargetBrowseButton_Click);
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.Location = new System.Drawing.Point(6, 34);
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.Size = new System.Drawing.Size(236, 20);
            this.TargetTextBox.TabIndex = 0;
            // 
            // FuzzOptionsTab
            // 
            this.FuzzOptionsTab.Controls.Add(this.NetworkFuzzerRadio);
            this.FuzzOptionsTab.Controls.Add(this.FileFormatRadio);
            this.FuzzOptionsTab.Controls.Add(this.FuzzerTabControl);
            this.FuzzOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.FuzzOptionsTab.Name = "FuzzOptionsTab";
            this.FuzzOptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FuzzOptionsTab.Size = new System.Drawing.Size(329, 490);
            this.FuzzOptionsTab.TabIndex = 1;
            this.FuzzOptionsTab.Text = "Fuzzer";
            this.FuzzOptionsTab.UseVisualStyleBackColor = true;
            // 
            // NetworkFuzzerRadio
            // 
            this.NetworkFuzzerRadio.AutoSize = true;
            this.NetworkFuzzerRadio.Location = new System.Drawing.Point(65, 30);
            this.NetworkFuzzerRadio.Name = "NetworkFuzzerRadio";
            this.NetworkFuzzerRadio.Size = new System.Drawing.Size(99, 17);
            this.NetworkFuzzerRadio.TabIndex = 2;
            this.NetworkFuzzerRadio.TabStop = true;
            this.NetworkFuzzerRadio.Text = "Network Fuzzer";
            this.NetworkFuzzerRadio.UseVisualStyleBackColor = true;
            this.NetworkFuzzerRadio.CheckedChanged += new System.EventHandler(this.NetworkFuzzerRadio_CheckedChanged);
            // 
            // FileFormatRadio
            // 
            this.FileFormatRadio.AutoSize = true;
            this.FileFormatRadio.Location = new System.Drawing.Point(7, 7);
            this.FileFormatRadio.Name = "FileFormatRadio";
            this.FileFormatRadio.Size = new System.Drawing.Size(76, 17);
            this.FileFormatRadio.TabIndex = 1;
            this.FileFormatRadio.TabStop = true;
            this.FileFormatRadio.Text = "File Format";
            this.FileFormatRadio.UseVisualStyleBackColor = true;
            this.FileFormatRadio.CheckedChanged += new System.EventHandler(this.FileFormatRadio_CheckedChanged);
            // 
            // FuzzerTabControl
            // 
            this.FuzzerTabControl.Controls.Add(this.FileFormatTab);
            this.FuzzerTabControl.Controls.Add(this.NetworkFuzzerTab);
            this.FuzzerTabControl.Location = new System.Drawing.Point(0, 54);
            this.FuzzerTabControl.Name = "FuzzerTabControl";
            this.FuzzerTabControl.SelectedIndex = 0;
            this.FuzzerTabControl.Size = new System.Drawing.Size(326, 440);
            this.FuzzerTabControl.TabIndex = 0;
            // 
            // FileFormatTab
            // 
            this.FileFormatTab.Controls.Add(this.RandomFuzzRadio);
            this.FileFormatTab.Controls.Add(this.SequentialFuzzerRadio);
            this.FileFormatTab.Controls.Add(this.FileFormatTabControl);
            this.FileFormatTab.Location = new System.Drawing.Point(4, 22);
            this.FileFormatTab.Name = "FileFormatTab";
            this.FileFormatTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileFormatTab.Size = new System.Drawing.Size(318, 414);
            this.FileFormatTab.TabIndex = 0;
            this.FileFormatTab.Text = "File Format";
            this.FileFormatTab.UseVisualStyleBackColor = true;
            // 
            // RandomFuzzRadio
            // 
            this.RandomFuzzRadio.AutoSize = true;
            this.RandomFuzzRadio.Location = new System.Drawing.Point(65, 30);
            this.RandomFuzzRadio.Name = "RandomFuzzRadio";
            this.RandomFuzzRadio.Size = new System.Drawing.Size(87, 17);
            this.RandomFuzzRadio.TabIndex = 2;
            this.RandomFuzzRadio.TabStop = true;
            this.RandomFuzzRadio.Text = "RandomFuzz";
            this.RandomFuzzRadio.UseVisualStyleBackColor = true;
            this.RandomFuzzRadio.CheckedChanged += new System.EventHandler(this.RandomFuzzRadio_CheckedChanged);
            // 
            // SequentialFuzzerRadio
            // 
            this.SequentialFuzzerRadio.AutoSize = true;
            this.SequentialFuzzerRadio.Location = new System.Drawing.Point(7, 7);
            this.SequentialFuzzerRadio.Name = "SequentialFuzzerRadio";
            this.SequentialFuzzerRadio.Size = new System.Drawing.Size(75, 17);
            this.SequentialFuzzerRadio.TabIndex = 1;
            this.SequentialFuzzerRadio.TabStop = true;
            this.SequentialFuzzerRadio.Text = "Sequential";
            this.SequentialFuzzerRadio.UseVisualStyleBackColor = true;
            this.SequentialFuzzerRadio.CheckedChanged += new System.EventHandler(this.SequentialFuzzerRadio_CheckedChanged);
            // 
            // FileFormatTabControl
            // 
            this.FileFormatTabControl.Controls.Add(this.SequentialTab);
            this.FileFormatTabControl.Controls.Add(this.RandomFuzzTab);
            this.FileFormatTabControl.Location = new System.Drawing.Point(2, 53);
            this.FileFormatTabControl.Name = "FileFormatTabControl";
            this.FileFormatTabControl.SelectedIndex = 0;
            this.FileFormatTabControl.Size = new System.Drawing.Size(313, 361);
            this.FileFormatTabControl.TabIndex = 0;
            // 
            // SequentialTab
            // 
            this.SequentialTab.Controls.Add(this.SequentialOptionsGroupBox);
            this.SequentialTab.Location = new System.Drawing.Point(4, 22);
            this.SequentialTab.Name = "SequentialTab";
            this.SequentialTab.Padding = new System.Windows.Forms.Padding(3);
            this.SequentialTab.Size = new System.Drawing.Size(305, 335);
            this.SequentialTab.TabIndex = 0;
            this.SequentialTab.Text = "Sequential";
            this.SequentialTab.UseVisualStyleBackColor = true;
            // 
            // SequentialOptionsGroupBox
            // 
            this.SequentialOptionsGroupBox.Controls.Add(this.label16);
            this.SequentialOptionsGroupBox.Controls.Add(this.label15);
            this.SequentialOptionsGroupBox.Controls.Add(this.label14);
            this.SequentialOptionsGroupBox.Controls.Add(this.label13);
            this.SequentialOptionsGroupBox.Controls.Add(this.SequentialFuzzModificationIncrement);
            this.SequentialOptionsGroupBox.Controls.Add(this.SequentialFuzzModificationSize);
            this.SequentialOptionsGroupBox.Controls.Add(this.SequentialFuzModificationBytes);
            this.SequentialOptionsGroupBox.Controls.Add(this.SequentialFuzzModificationOptions);
            this.SequentialOptionsGroupBox.Controls.Add(this.label12);
            this.SequentialOptionsGroupBox.Controls.Add(this.SequentialFuzzEndingOffset);
            this.SequentialOptionsGroupBox.Controls.Add(this.label11);
            this.SequentialOptionsGroupBox.Controls.Add(this.label10);
            this.SequentialOptionsGroupBox.Controls.Add(this.SequentialFuzzStartingOffset);
            this.SequentialOptionsGroupBox.Enabled = false;
            this.SequentialOptionsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.SequentialOptionsGroupBox.Name = "SequentialOptionsGroupBox";
            this.SequentialOptionsGroupBox.Size = new System.Drawing.Size(313, 326);
            this.SequentialOptionsGroupBox.TabIndex = 1;
            this.SequentialOptionsGroupBox.TabStop = false;
            this.SequentialOptionsGroupBox.Text = "Options";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(151, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Modification Byte";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Modification Operation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Modification Size";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Modification Increment";
            // 
            // SequentialFuzzModificationIncrement
            // 
            this.SequentialFuzzModificationIncrement.CheckOnClick = true;
            this.SequentialFuzzModificationIncrement.FormattingEnabled = true;
            this.SequentialFuzzModificationIncrement.Location = new System.Drawing.Point(151, 226);
            this.SequentialFuzzModificationIncrement.Name = "SequentialFuzzModificationIncrement";
            this.SequentialFuzzModificationIncrement.Size = new System.Drawing.Size(142, 94);
            this.SequentialFuzzModificationIncrement.TabIndex = 8;
            this.SequentialFuzzModificationIncrement.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SequentialFuzzModificationIncrement_ItemCheck);
            // 
            // SequentialFuzzModificationSize
            // 
            this.SequentialFuzzModificationSize.CheckOnClick = true;
            this.SequentialFuzzModificationSize.FormattingEnabled = true;
            this.SequentialFuzzModificationSize.Location = new System.Drawing.Point(6, 226);
            this.SequentialFuzzModificationSize.Name = "SequentialFuzzModificationSize";
            this.SequentialFuzzModificationSize.Size = new System.Drawing.Size(142, 94);
            this.SequentialFuzzModificationSize.TabIndex = 7;
            this.SequentialFuzzModificationSize.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SequentialFuzzModificationSize_ItemCheck);
            // 
            // SequentialFuzModificationBytes
            // 
            this.SequentialFuzModificationBytes.CheckOnClick = true;
            this.SequentialFuzModificationBytes.FormattingEnabled = true;
            this.SequentialFuzModificationBytes.Location = new System.Drawing.Point(151, 96);
            this.SequentialFuzModificationBytes.Name = "SequentialFuzModificationBytes";
            this.SequentialFuzModificationBytes.Size = new System.Drawing.Size(142, 94);
            this.SequentialFuzModificationBytes.TabIndex = 6;
            this.SequentialFuzModificationBytes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SequentialFuzModificationBytes_ItemCheck);
            // 
            // SequentialFuzzModificationOptions
            // 
            this.SequentialFuzzModificationOptions.CheckOnClick = true;
            this.SequentialFuzzModificationOptions.FormattingEnabled = true;
            this.SequentialFuzzModificationOptions.Location = new System.Drawing.Point(6, 96);
            this.SequentialFuzzModificationOptions.Name = "SequentialFuzzModificationOptions";
            this.SequentialFuzzModificationOptions.Size = new System.Drawing.Size(142, 94);
            this.SequentialFuzzModificationOptions.TabIndex = 5;
            this.SequentialFuzzModificationOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SequentialFuzzModificationOptions_ItemCheck);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "(0 For Full File)";
            // 
            // SequentialFuzzEndingOffset
            // 
            this.SequentialFuzzEndingOffset.Location = new System.Drawing.Point(106, 41);
            this.SequentialFuzzEndingOffset.Name = "SequentialFuzzEndingOffset";
            this.SequentialFuzzEndingOffset.Size = new System.Drawing.Size(82, 20);
            this.SequentialFuzzEndingOffset.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ending Offset %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Starting Offset %";
            // 
            // SequentialFuzzStartingOffset
            // 
            this.SequentialFuzzStartingOffset.Location = new System.Drawing.Point(106, 17);
            this.SequentialFuzzStartingOffset.Name = "SequentialFuzzStartingOffset";
            this.SequentialFuzzStartingOffset.Size = new System.Drawing.Size(82, 20);
            this.SequentialFuzzStartingOffset.TabIndex = 0;
            // 
            // RandomFuzzTab
            // 
            this.RandomFuzzTab.Controls.Add(this.RandomFuzzOptionsGroupBox);
            this.RandomFuzzTab.Location = new System.Drawing.Point(4, 22);
            this.RandomFuzzTab.Name = "RandomFuzzTab";
            this.RandomFuzzTab.Padding = new System.Windows.Forms.Padding(3);
            this.RandomFuzzTab.Size = new System.Drawing.Size(305, 335);
            this.RandomFuzzTab.TabIndex = 1;
            this.RandomFuzzTab.Text = "RandomFuzz";
            this.RandomFuzzTab.UseVisualStyleBackColor = true;
            // 
            // RandomFuzzOptionsGroupBox
            // 
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.label18);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.label17);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzEndFilePercentageTextBox);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzStartFilePercentageTextBox);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzPermutationBytes);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzModificationOptionsCheckList);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzTotalAttemptsTextBox);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzTotalAttemptsLabel);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.RandomFuzzSprayTextBox);
            this.RandomFuzzOptionsGroupBox.Controls.Add(this.label6);
            this.RandomFuzzOptionsGroupBox.Enabled = false;
            this.RandomFuzzOptionsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RandomFuzzOptionsGroupBox.Name = "RandomFuzzOptionsGroupBox";
            this.RandomFuzzOptionsGroupBox.Size = new System.Drawing.Size(293, 323);
            this.RandomFuzzOptionsGroupBox.TabIndex = 1;
            this.RandomFuzzOptionsGroupBox.TabStop = false;
            this.RandomFuzzOptionsGroupBox.Text = "Options";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Start File %";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "End File %";
            // 
            // RandomFuzzEndFilePercentageTextBox
            // 
            this.RandomFuzzEndFilePercentageTextBox.Location = new System.Drawing.Point(157, 71);
            this.RandomFuzzEndFilePercentageTextBox.Name = "RandomFuzzEndFilePercentageTextBox";
            this.RandomFuzzEndFilePercentageTextBox.Size = new System.Drawing.Size(130, 20);
            this.RandomFuzzEndFilePercentageTextBox.TabIndex = 7;
            // 
            // RandomFuzzStartFilePercentageTextBox
            // 
            this.RandomFuzzStartFilePercentageTextBox.Location = new System.Drawing.Point(157, 44);
            this.RandomFuzzStartFilePercentageTextBox.Name = "RandomFuzzStartFilePercentageTextBox";
            this.RandomFuzzStartFilePercentageTextBox.Size = new System.Drawing.Size(130, 20);
            this.RandomFuzzStartFilePercentageTextBox.TabIndex = 6;
            // 
            // RandomFuzzPermutationBytes
            // 
            this.RandomFuzzPermutationBytes.CheckOnClick = true;
            this.RandomFuzzPermutationBytes.FormattingEnabled = true;
            this.RandomFuzzPermutationBytes.Location = new System.Drawing.Point(167, 128);
            this.RandomFuzzPermutationBytes.Name = "RandomFuzzPermutationBytes";
            this.RandomFuzzPermutationBytes.Size = new System.Drawing.Size(120, 169);
            this.RandomFuzzPermutationBytes.TabIndex = 5;
            // 
            // RandomFuzzModificationOptionsCheckList
            // 
            this.RandomFuzzModificationOptionsCheckList.CheckOnClick = true;
            this.RandomFuzzModificationOptionsCheckList.FormattingEnabled = true;
            this.RandomFuzzModificationOptionsCheckList.Location = new System.Drawing.Point(10, 128);
            this.RandomFuzzModificationOptionsCheckList.Name = "RandomFuzzModificationOptionsCheckList";
            this.RandomFuzzModificationOptionsCheckList.Size = new System.Drawing.Size(119, 169);
            this.RandomFuzzModificationOptionsCheckList.TabIndex = 4;
            // 
            // RandomFuzzTotalAttemptsTextBox
            // 
            this.RandomFuzzTotalAttemptsTextBox.Location = new System.Drawing.Point(157, 97);
            this.RandomFuzzTotalAttemptsTextBox.Name = "RandomFuzzTotalAttemptsTextBox";
            this.RandomFuzzTotalAttemptsTextBox.Size = new System.Drawing.Size(130, 20);
            this.RandomFuzzTotalAttemptsTextBox.TabIndex = 3;
            // 
            // RandomFuzzTotalAttemptsLabel
            // 
            this.RandomFuzzTotalAttemptsLabel.AutoSize = true;
            this.RandomFuzzTotalAttemptsLabel.Location = new System.Drawing.Point(7, 100);
            this.RandomFuzzTotalAttemptsLabel.Name = "RandomFuzzTotalAttemptsLabel";
            this.RandomFuzzTotalAttemptsLabel.Size = new System.Drawing.Size(75, 13);
            this.RandomFuzzTotalAttemptsLabel.TabIndex = 2;
            this.RandomFuzzTotalAttemptsLabel.Text = "Total Attempts";
            // 
            // RandomFuzzSprayTextBox
            // 
            this.RandomFuzzSprayTextBox.Location = new System.Drawing.Point(157, 17);
            this.RandomFuzzSprayTextBox.Name = "RandomFuzzSprayTextBox";
            this.RandomFuzzSprayTextBox.Size = new System.Drawing.Size(130, 20);
            this.RandomFuzzSprayTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Spray Percentage (1-99)";
            // 
            // NetworkFuzzerTab
            // 
            this.NetworkFuzzerTab.Controls.Add(this.PcapRandomFuzzRadio);
            this.NetworkFuzzerTab.Controls.Add(this.NetworkFuzzerTabControl);
            this.NetworkFuzzerTab.Location = new System.Drawing.Point(4, 22);
            this.NetworkFuzzerTab.Name = "NetworkFuzzerTab";
            this.NetworkFuzzerTab.Size = new System.Drawing.Size(318, 414);
            this.NetworkFuzzerTab.TabIndex = 1;
            this.NetworkFuzzerTab.Text = "Network Fuzzer";
            this.NetworkFuzzerTab.UseVisualStyleBackColor = true;
            // 
            // PcapRandomFuzzRadio
            // 
            this.PcapRandomFuzzRadio.AutoSize = true;
            this.PcapRandomFuzzRadio.Location = new System.Drawing.Point(108, 29);
            this.PcapRandomFuzzRadio.Name = "PcapRandomFuzzRadio";
            this.PcapRandomFuzzRadio.Size = new System.Drawing.Size(112, 17);
            this.PcapRandomFuzzRadio.TabIndex = 1;
            this.PcapRandomFuzzRadio.TabStop = true;
            this.PcapRandomFuzzRadio.Text = "PcapRandomFuzz";
            this.PcapRandomFuzzRadio.UseVisualStyleBackColor = true;
            this.PcapRandomFuzzRadio.CheckedChanged += new System.EventHandler(this.PcapRandomFuzzRadio_CheckedChanged);
            // 
            // NetworkFuzzerTabControl
            // 
            this.NetworkFuzzerTabControl.Controls.Add(this.PcapStringFuzzTab);
            this.NetworkFuzzerTabControl.Controls.Add(this.PcapRandomFuzzTab);
            this.NetworkFuzzerTabControl.Location = new System.Drawing.Point(3, 52);
            this.NetworkFuzzerTabControl.Name = "NetworkFuzzerTabControl";
            this.NetworkFuzzerTabControl.SelectedIndex = 0;
            this.NetworkFuzzerTabControl.Size = new System.Drawing.Size(312, 356);
            this.NetworkFuzzerTabControl.TabIndex = 0;
            // 
            // PcapStringFuzzTab
            // 
            this.PcapStringFuzzTab.Location = new System.Drawing.Point(4, 22);
            this.PcapStringFuzzTab.Name = "PcapStringFuzzTab";
            this.PcapStringFuzzTab.Padding = new System.Windows.Forms.Padding(3);
            this.PcapStringFuzzTab.Size = new System.Drawing.Size(304, 330);
            this.PcapStringFuzzTab.TabIndex = 0;
            this.PcapStringFuzzTab.Text = "PcapStringFuzzer";
            this.PcapStringFuzzTab.UseVisualStyleBackColor = true;
            // 
            // PcapRandomFuzzTab
            // 
            this.PcapRandomFuzzTab.Controls.Add(this.PcapRandomFuzzGroupBox);
            this.PcapRandomFuzzTab.Location = new System.Drawing.Point(4, 22);
            this.PcapRandomFuzzTab.Name = "PcapRandomFuzzTab";
            this.PcapRandomFuzzTab.Padding = new System.Windows.Forms.Padding(3);
            this.PcapRandomFuzzTab.Size = new System.Drawing.Size(304, 330);
            this.PcapRandomFuzzTab.TabIndex = 1;
            this.PcapRandomFuzzTab.Text = "PcapRandomFuzz";
            this.PcapRandomFuzzTab.UseVisualStyleBackColor = true;
            // 
            // PcapRandomFuzzGroupBox
            // 
            this.PcapRandomFuzzGroupBox.Location = new System.Drawing.Point(7, 7);
            this.PcapRandomFuzzGroupBox.Name = "PcapRandomFuzzGroupBox";
            this.PcapRandomFuzzGroupBox.Size = new System.Drawing.Size(291, 317);
            this.PcapRandomFuzzGroupBox.TabIndex = 0;
            this.PcapRandomFuzzGroupBox.TabStop = false;
            this.PcapRandomFuzzGroupBox.Text = "Options";
            // 
            // DebuggerOptionsTab
            // 
            this.DebuggerOptionsTab.Controls.Add(this.groupBox2);
            this.DebuggerOptionsTab.Controls.Add(this.groupBox1);
            this.DebuggerOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.DebuggerOptionsTab.Name = "DebuggerOptionsTab";
            this.DebuggerOptionsTab.Size = new System.Drawing.Size(329, 490);
            this.DebuggerOptionsTab.TabIndex = 2;
            this.DebuggerOptionsTab.Text = "Debugger";
            this.DebuggerOptionsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IgnoreExceptionsCheckbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MoveAllIgnoreButton);
            this.groupBox2.Controls.Add(this.SingleToIgnoreButton);
            this.groupBox2.Controls.Add(this.MoveAllRecordButton);
            this.groupBox2.Controls.Add(this.SingleToRecordButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.FilterErrorCodesTextBox);
            this.groupBox2.Controls.Add(this.RecordedExceptoinsListBox);
            this.groupBox2.Controls.Add(this.IgnoredListBox);
            this.groupBox2.Location = new System.Drawing.Point(4, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exception and Error Codes";
            // 
            // IgnoreExceptionsCheckbox
            // 
            this.IgnoreExceptionsCheckbox.AutoSize = true;
            this.IgnoreExceptionsCheckbox.Location = new System.Drawing.Point(8, 60);
            this.IgnoreExceptionsCheckbox.Name = "IgnoreExceptionsCheckbox";
            this.IgnoreExceptionsCheckbox.Size = new System.Drawing.Size(125, 17);
            this.IgnoreExceptionsCheckbox.TabIndex = 11;
            this.IgnoreExceptionsCheckbox.Text = "Ignore All Exceptions";
            this.IgnoreExceptionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Record";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ignore";
            // 
            // MoveAllIgnoreButton
            // 
            this.MoveAllIgnoreButton.Location = new System.Drawing.Point(146, 220);
            this.MoveAllIgnoreButton.Name = "MoveAllIgnoreButton";
            this.MoveAllIgnoreButton.Size = new System.Drawing.Size(29, 23);
            this.MoveAllIgnoreButton.TabIndex = 8;
            this.MoveAllIgnoreButton.Text = "<<";
            this.MoveAllIgnoreButton.UseVisualStyleBackColor = true;
            this.MoveAllIgnoreButton.Click += new System.EventHandler(this.MoveAllIgnoreButton_Click);
            // 
            // SingleToIgnoreButton
            // 
            this.SingleToIgnoreButton.Location = new System.Drawing.Point(145, 162);
            this.SingleToIgnoreButton.Name = "SingleToIgnoreButton";
            this.SingleToIgnoreButton.Size = new System.Drawing.Size(30, 23);
            this.SingleToIgnoreButton.TabIndex = 7;
            this.SingleToIgnoreButton.Text = "<";
            this.SingleToIgnoreButton.UseVisualStyleBackColor = true;
            this.SingleToIgnoreButton.Click += new System.EventHandler(this.SingleToIgnoreButton_Click);
            // 
            // MoveAllRecordButton
            // 
            this.MoveAllRecordButton.Location = new System.Drawing.Point(145, 191);
            this.MoveAllRecordButton.Name = "MoveAllRecordButton";
            this.MoveAllRecordButton.Size = new System.Drawing.Size(30, 23);
            this.MoveAllRecordButton.TabIndex = 5;
            this.MoveAllRecordButton.Text = ">>";
            this.MoveAllRecordButton.UseVisualStyleBackColor = true;
            this.MoveAllRecordButton.Click += new System.EventHandler(this.MoveAllRecordButton_Click);
            // 
            // SingleToRecordButton
            // 
            this.SingleToRecordButton.Location = new System.Drawing.Point(145, 133);
            this.SingleToRecordButton.Name = "SingleToRecordButton";
            this.SingleToRecordButton.Size = new System.Drawing.Size(30, 23);
            this.SingleToRecordButton.TabIndex = 4;
            this.SingleToRecordButton.Text = ">";
            this.SingleToRecordButton.UseVisualStyleBackColor = true;
            this.SingleToRecordButton.Click += new System.EventHandler(this.SingleToRecordButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search";
            // 
            // FilterErrorCodesTextBox
            // 
            this.FilterErrorCodesTextBox.Location = new System.Drawing.Point(6, 34);
            this.FilterErrorCodesTextBox.Name = "FilterErrorCodesTextBox";
            this.FilterErrorCodesTextBox.Size = new System.Drawing.Size(309, 20);
            this.FilterErrorCodesTextBox.TabIndex = 2;
            this.FilterErrorCodesTextBox.TextChanged += new System.EventHandler(this.FilterErrorCodesTextBox_TextChanged);
            // 
            // RecordedExceptoinsListBox
            // 
            this.RecordedExceptoinsListBox.FormattingEnabled = true;
            this.RecordedExceptoinsListBox.HorizontalScrollbar = true;
            this.RecordedExceptoinsListBox.Location = new System.Drawing.Point(181, 96);
            this.RecordedExceptoinsListBox.Name = "RecordedExceptoinsListBox";
            this.RecordedExceptoinsListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecordedExceptoinsListBox.Size = new System.Drawing.Size(134, 186);
            this.RecordedExceptoinsListBox.TabIndex = 1;
            // 
            // IgnoredListBox
            // 
            this.IgnoredListBox.FormattingEnabled = true;
            this.IgnoredListBox.HorizontalScrollbar = true;
            this.IgnoredListBox.Location = new System.Drawing.Point(5, 96);
            this.IgnoredListBox.Name = "IgnoredListBox";
            this.IgnoredListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IgnoredListBox.Size = new System.Drawing.Size(134, 186);
            this.IgnoredListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HideDebuggerCheckBox);
            this.groupBox1.Controls.Add(this.WaitForFullStartupCheckbox);
            this.groupBox1.Controls.Add(this.ProcessThresholdTextBox);
            this.groupBox1.Controls.Add(this.ProcessThresholdCheckbox);
            this.groupBox1.Controls.Add(this.KillAlsoCheckBox);
            this.groupBox1.Controls.Add(this.KillAlsoTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EventTimeoutTextbox);
            this.groupBox1.Controls.Add(this.GeneralTimeoutTextbox);
            this.groupBox1.Controls.Add(this.EventTimeoutCheckbox);
            this.groupBox1.Controls.Add(this.TimeoutEnabledCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Execution Termination Options";
            // 
            // HideDebuggerCheckBox
            // 
            this.HideDebuggerCheckBox.AutoSize = true;
            this.HideDebuggerCheckBox.Location = new System.Drawing.Point(7, 161);
            this.HideDebuggerCheckBox.Name = "HideDebuggerCheckBox";
            this.HideDebuggerCheckBox.Size = new System.Drawing.Size(180, 17);
            this.HideDebuggerCheckBox.TabIndex = 10;
            this.HideDebuggerCheckBox.Text = "Hide Debugger from Debuggee?";
            this.HideDebuggerCheckBox.UseVisualStyleBackColor = true;
            // 
            // WaitForFullStartupCheckbox
            // 
            this.WaitForFullStartupCheckbox.AutoSize = true;
            this.WaitForFullStartupCheckbox.Location = new System.Drawing.Point(7, 110);
            this.WaitForFullStartupCheckbox.Name = "WaitForFullStartupCheckbox";
            this.WaitForFullStartupCheckbox.Size = new System.Drawing.Size(154, 17);
            this.WaitForFullStartupCheckbox.TabIndex = 9;
            this.WaitForFullStartupCheckbox.Text = "Wait For Full Startup (Slow)";
            this.WaitForFullStartupCheckbox.UseVisualStyleBackColor = true;
            // 
            // ProcessThresholdTextBox
            // 
            this.ProcessThresholdTextBox.Location = new System.Drawing.Point(169, 84);
            this.ProcessThresholdTextBox.Name = "ProcessThresholdTextBox";
            this.ProcessThresholdTextBox.Size = new System.Drawing.Size(146, 20);
            this.ProcessThresholdTextBox.TabIndex = 8;
            // 
            // ProcessThresholdCheckbox
            // 
            this.ProcessThresholdCheckbox.AutoSize = true;
            this.ProcessThresholdCheckbox.Location = new System.Drawing.Point(7, 86);
            this.ProcessThresholdCheckbox.Name = "ProcessThresholdCheckbox";
            this.ProcessThresholdCheckbox.Size = new System.Drawing.Size(114, 17);
            this.ProcessThresholdCheckbox.TabIndex = 7;
            this.ProcessThresholdCheckbox.Text = "Process Threshold";
            this.ProcessThresholdCheckbox.UseVisualStyleBackColor = true;
            this.ProcessThresholdCheckbox.CheckedChanged += new System.EventHandler(this.ProcessThresholdCheckbox_CheckedChanged);
            // 
            // KillAlsoCheckBox
            // 
            this.KillAlsoCheckBox.AutoSize = true;
            this.KillAlsoCheckBox.Location = new System.Drawing.Point(7, 138);
            this.KillAlsoCheckBox.Name = "KillAlsoCheckBox";
            this.KillAlsoCheckBox.Size = new System.Drawing.Size(68, 17);
            this.KillAlsoCheckBox.TabIndex = 6;
            this.KillAlsoCheckBox.Text = "Kill Also: ";
            this.KillAlsoCheckBox.UseVisualStyleBackColor = true;
            this.KillAlsoCheckBox.CheckedChanged += new System.EventHandler(this.KillAlsoCheckBox_CheckedChanged);
            // 
            // KillAlsoTextBox
            // 
            this.KillAlsoTextBox.Enabled = false;
            this.KillAlsoTextBox.Location = new System.Drawing.Point(81, 136);
            this.KillAlsoTextBox.Name = "KillAlsoTextBox";
            this.KillAlsoTextBox.Size = new System.Drawing.Size(235, 20);
            this.KillAlsoTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Negative one (-1) for infinite";
            // 
            // EventTimeoutTextbox
            // 
            this.EventTimeoutTextbox.Enabled = false;
            this.EventTimeoutTextbox.Location = new System.Drawing.Point(169, 44);
            this.EventTimeoutTextbox.Name = "EventTimeoutTextbox";
            this.EventTimeoutTextbox.Size = new System.Drawing.Size(147, 20);
            this.EventTimeoutTextbox.TabIndex = 3;
            // 
            // GeneralTimeoutTextbox
            // 
            this.GeneralTimeoutTextbox.Enabled = false;
            this.GeneralTimeoutTextbox.Location = new System.Drawing.Point(169, 20);
            this.GeneralTimeoutTextbox.Name = "GeneralTimeoutTextbox";
            this.GeneralTimeoutTextbox.Size = new System.Drawing.Size(147, 20);
            this.GeneralTimeoutTextbox.TabIndex = 2;
            // 
            // EventTimeoutCheckbox
            // 
            this.EventTimeoutCheckbox.AutoSize = true;
            this.EventTimeoutCheckbox.Location = new System.Drawing.Point(7, 44);
            this.EventTimeoutCheckbox.Name = "EventTimeoutCheckbox";
            this.EventTimeoutCheckbox.Size = new System.Drawing.Size(137, 17);
            this.EventTimeoutCheckbox.TabIndex = 1;
            this.EventTimeoutCheckbox.Text = "Event Timeout (0-1000)";
            this.EventTimeoutCheckbox.UseVisualStyleBackColor = true;
            this.EventTimeoutCheckbox.CheckedChanged += new System.EventHandler(this.EventTimeoutCheckbox_CheckedChanged);
            // 
            // TimeoutEnabledCheckbox
            // 
            this.TimeoutEnabledCheckbox.AutoSize = true;
            this.TimeoutEnabledCheckbox.Location = new System.Drawing.Point(7, 20);
            this.TimeoutEnabledCheckbox.Name = "TimeoutEnabledCheckbox";
            this.TimeoutEnabledCheckbox.Size = new System.Drawing.Size(134, 17);
            this.TimeoutEnabledCheckbox.TabIndex = 0;
            this.TimeoutEnabledCheckbox.Text = "General Timeout (0-60)";
            this.TimeoutEnabledCheckbox.UseVisualStyleBackColor = true;
            this.TimeoutEnabledCheckbox.CheckedChanged += new System.EventHandler(this.TimeoutEnabledCheckbox_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.SummaryTab);
            this.tabControl2.Controls.Add(this.DetailsTab);
            this.tabControl2.Location = new System.Drawing.Point(355, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(375, 516);
            this.tabControl2.TabIndex = 4;
            // 
            // SummaryTab
            // 
            this.SummaryTab.Controls.Add(this.SummaryBox);
            this.SummaryTab.Location = new System.Drawing.Point(4, 22);
            this.SummaryTab.Name = "SummaryTab";
            this.SummaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryTab.Size = new System.Drawing.Size(367, 490);
            this.SummaryTab.TabIndex = 0;
            this.SummaryTab.Text = "Summary";
            this.SummaryTab.UseVisualStyleBackColor = true;
            // 
            // SummaryBox
            // 
            this.SummaryBox.Location = new System.Drawing.Point(6, 6);
            this.SummaryBox.Multiline = true;
            this.SummaryBox.Name = "SummaryBox";
            this.SummaryBox.ReadOnly = true;
            this.SummaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SummaryBox.Size = new System.Drawing.Size(355, 478);
            this.SummaryBox.TabIndex = 0;
            // 
            // DetailsTab
            // 
            this.DetailsTab.Controls.Add(this.DetailsBox);
            this.DetailsTab.Location = new System.Drawing.Point(4, 22);
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTab.Size = new System.Drawing.Size(367, 490);
            this.DetailsTab.TabIndex = 1;
            this.DetailsTab.Text = "Crash Details";
            this.DetailsTab.UseVisualStyleBackColor = true;
            // 
            // DetailsBox
            // 
            this.DetailsBox.Location = new System.Drawing.Point(6, 6);
            this.DetailsBox.Multiline = true;
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.ReadOnly = true;
            this.DetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailsBox.Size = new System.Drawing.Size(355, 478);
            this.DetailsBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 569);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 607);
            this.MinimumSize = new System.Drawing.Size(758, 607);
            this.Name = "Form1";
            this.Text = "GreyBush - Alpha Version";
            this.tabControl1.ResumeLayout(false);
            this.FileOptionsTab.ResumeLayout(false);
            this.FileOptionsTab.PerformLayout();
            this.FuzzOptionsTab.ResumeLayout(false);
            this.FuzzOptionsTab.PerformLayout();
            this.FuzzerTabControl.ResumeLayout(false);
            this.FileFormatTab.ResumeLayout(false);
            this.FileFormatTab.PerformLayout();
            this.FileFormatTabControl.ResumeLayout(false);
            this.SequentialTab.ResumeLayout(false);
            this.SequentialOptionsGroupBox.ResumeLayout(false);
            this.SequentialOptionsGroupBox.PerformLayout();
            this.RandomFuzzTab.ResumeLayout(false);
            this.RandomFuzzOptionsGroupBox.ResumeLayout(false);
            this.RandomFuzzOptionsGroupBox.PerformLayout();
            this.NetworkFuzzerTab.ResumeLayout(false);
            this.NetworkFuzzerTab.PerformLayout();
            this.NetworkFuzzerTabControl.ResumeLayout(false);
            this.PcapRandomFuzzTab.ResumeLayout(false);
            this.DebuggerOptionsTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.SummaryTab.ResumeLayout(false);
            this.SummaryTab.PerformLayout();
            this.DetailsTab.ResumeLayout(false);
            this.DetailsTab.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button GoButton;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage FileOptionsTab;
		private System.Windows.Forms.TabPage FuzzOptionsTab;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage SummaryTab;
		private System.Windows.Forms.TabPage DetailsTab;
		private System.Windows.Forms.TextBox SummaryBox;
		private System.Windows.Forms.TextBox DetailsBox;
		private System.Windows.Forms.TextBox CommandLineArgsTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BaseFileButton;
		private System.Windows.Forms.TextBox BaseFileTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CrashDirectoryTextBox;
		private System.Windows.Forms.Button CrashDirectoryButton;
		private System.Windows.Forms.Button TargetBrowseButton;
		private System.Windows.Forms.TextBox TargetTextBox;
		private System.Windows.Forms.CheckBox HideWindowCheckBox;
		private System.Windows.Forms.CheckBox OKbeforeCloseCheckBox;
		private System.Windows.Forms.CheckBox AutoCloseCheckBox;
		private System.Windows.Forms.TabPage DebuggerOptionsTab;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox EventTimeoutTextbox;
		private System.Windows.Forms.TextBox GeneralTimeoutTextbox;
		private System.Windows.Forms.CheckBox EventTimeoutCheckbox;
		private System.Windows.Forms.CheckBox TimeoutEnabledCheckbox;
		private System.Windows.Forms.TabControl FuzzerTabControl;
		private System.Windows.Forms.TabPage FileFormatTab;
		private System.Windows.Forms.TabControl FileFormatTabControl;
		private System.Windows.Forms.TabPage SequentialTab;
		private System.Windows.Forms.TabPage RandomFuzzTab;
		private System.Windows.Forms.GroupBox RandomFuzzOptionsGroupBox;
		private System.Windows.Forms.GroupBox SequentialOptionsGroupBox;
		private System.Windows.Forms.RadioButton RandomFuzzRadio;
		private System.Windows.Forms.RadioButton SequentialFuzzerRadio;
		private System.Windows.Forms.TextBox RandomFuzzSprayTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox FilterErrorCodesTextBox;
		private System.Windows.Forms.ListBox RecordedExceptoinsListBox;
		private System.Windows.Forms.ListBox IgnoredListBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button MoveAllIgnoreButton;
		private System.Windows.Forms.Button SingleToIgnoreButton;
		private System.Windows.Forms.Button MoveAllRecordButton;
		private System.Windows.Forms.Button SingleToRecordButton;
		private System.Windows.Forms.CheckBox KillAlsoCheckBox;
		private System.Windows.Forms.TextBox KillAlsoTextBox;
		private System.Windows.Forms.TabPage NetworkFuzzerTab;
		private System.Windows.Forms.CheckBox IgnoreExceptionsCheckbox;
		private System.Windows.Forms.RadioButton NetworkFuzzerRadio;
		private System.Windows.Forms.RadioButton FileFormatRadio;
		private System.Windows.Forms.TextBox RandomFuzzTotalAttemptsTextBox;
		private System.Windows.Forms.Label RandomFuzzTotalAttemptsLabel;
		private System.Windows.Forms.CheckedListBox RandomFuzzPermutationBytes;
		private System.Windows.Forms.CheckedListBox RandomFuzzModificationOptionsCheckList;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox SequentialFuzzEndingOffset;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox SequentialFuzzStartingOffset;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckedListBox SequentialFuzzModificationIncrement;
		private System.Windows.Forms.CheckedListBox SequentialFuzzModificationSize;
		private System.Windows.Forms.CheckedListBox SequentialFuzModificationBytes;
		private System.Windows.Forms.CheckedListBox SequentialFuzzModificationOptions;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox RandomFuzzEndFilePercentageTextBox;
		private System.Windows.Forms.TextBox RandomFuzzStartFilePercentageTextBox;
		private System.Windows.Forms.TabControl NetworkFuzzerTabControl;
		private System.Windows.Forms.TabPage PcapStringFuzzTab;
		private System.Windows.Forms.TabPage PcapRandomFuzzTab;
		private System.Windows.Forms.RadioButton PcapRandomFuzzRadio;
		private System.Windows.Forms.GroupBox PcapRandomFuzzGroupBox;
		private System.Windows.Forms.CheckBox AlwaysClickButtonsCheckBox;
		private System.Windows.Forms.CheckBox WaitForFullStartupCheckbox;
		private System.Windows.Forms.TextBox ProcessThresholdTextBox;
		private System.Windows.Forms.CheckBox ProcessThresholdCheckbox;
		private System.Windows.Forms.CheckBox HideDebuggerCheckBox;
		private System.Windows.Forms.CheckBox OnlyCloseWithClickCheckbox;


	}
}


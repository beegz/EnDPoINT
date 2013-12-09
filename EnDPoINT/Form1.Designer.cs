namespace EnDPoINT
{
    partial class frmMain
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
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarNetworkCommunication = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDICOM = new System.Windows.Forms.TabPage();
            this.labelShowLogLevel = new System.Windows.Forms.Label();
            this.labelLogLevel = new System.Windows.Forms.Label();
            this.labelShowPrintHeaders = new System.Windows.Forms.Label();
            this.labelPrintHeaders = new System.Windows.Forms.Label();
            this.labelShowPrinter = new System.Windows.Forms.Label();
            this.labelDisplayPrinter = new System.Windows.Forms.Label();
            this.labelShowAETitle = new System.Windows.Forms.Label();
            this.labelShowPort = new System.Windows.Forms.Label();
            this.labelDisplayAETitle = new System.Windows.Forms.Label();
            this.labelDisplayPort = new System.Windows.Forms.Label();
            this.labelShowIP = new System.Windows.Forms.Label();
            this.labelDisplayIP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelAETitle = new System.Windows.Forms.Label();
            this.textBoxAETitle = new System.Windows.Forms.TextBox();
            this.buttonUpdateDICOM = new System.Windows.Forms.Button();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.buttonServer = new System.Windows.Forms.Button();
            this.tabPagePrint = new System.Windows.Forms.TabPage();
            this.buttonPageDown = new System.Windows.Forms.Button();
            this.comboBoxPrintPreviewZoom = new System.Windows.Forms.ComboBox();
            this.buttonPageUp = new System.Windows.Forms.Button();
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.groupBoxPrint = new System.Windows.Forms.GroupBox();
            this.checkBoxDICOMHeader = new System.Windows.Forms.CheckBox();
            this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxLogfile = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonSetLogfile = new System.Windows.Forms.Button();
            this.openFileDialogLogfile = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEnDPoINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxDebugFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxInfoFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxWarningFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxFatalFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxErrorFilter = new System.Windows.Forms.CheckBox();
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageDICOM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.tabPagePrint.SuspendLayout();
            this.groupBoxPrint.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Text = "EnDPoINT DICOM Printserver";
            this.notifyIconMain.Visible = true;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelServer,
            this.toolStripProgressBarNetworkCommunication});
            this.statusStripMain.Location = new System.Drawing.Point(0, 419);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(624, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelServer
            // 
            this.toolStripStatusLabelServer.Name = "toolStripStatusLabelServer";
            this.toolStripStatusLabelServer.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabelServer.Text = "Server setting up...";
            // 
            // toolStripProgressBarNetworkCommunication
            // 
            this.toolStripProgressBarNetworkCommunication.Name = "toolStripProgressBarNetworkCommunication";
            this.toolStripProgressBarNetworkCommunication.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDICOM);
            this.tabControlMain.Controls.Add(this.tabPagePrint);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Location = new System.Drawing.Point(12, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(600, 385);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageDICOM
            // 
            this.tabPageDICOM.Controls.Add(this.labelShowLogLevel);
            this.tabPageDICOM.Controls.Add(this.labelLogLevel);
            this.tabPageDICOM.Controls.Add(this.labelShowPrintHeaders);
            this.tabPageDICOM.Controls.Add(this.labelPrintHeaders);
            this.tabPageDICOM.Controls.Add(this.labelShowPrinter);
            this.tabPageDICOM.Controls.Add(this.labelDisplayPrinter);
            this.tabPageDICOM.Controls.Add(this.labelShowAETitle);
            this.tabPageDICOM.Controls.Add(this.labelShowPort);
            this.tabPageDICOM.Controls.Add(this.labelDisplayAETitle);
            this.tabPageDICOM.Controls.Add(this.labelDisplayPort);
            this.tabPageDICOM.Controls.Add(this.labelShowIP);
            this.tabPageDICOM.Controls.Add(this.labelDisplayIP);
            this.tabPageDICOM.Controls.Add(this.groupBox1);
            this.tabPageDICOM.Controls.Add(this.pictureBoxStatus);
            this.tabPageDICOM.Controls.Add(this.buttonServer);
            this.tabPageDICOM.Location = new System.Drawing.Point(4, 22);
            this.tabPageDICOM.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabPageDICOM.Name = "tabPageDICOM";
            this.tabPageDICOM.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabPageDICOM.Size = new System.Drawing.Size(592, 359);
            this.tabPageDICOM.TabIndex = 0;
            this.tabPageDICOM.Text = "DICOM";
            this.tabPageDICOM.UseVisualStyleBackColor = true;
            // 
            // labelShowLogLevel
            // 
            this.labelShowLogLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowLogLevel.Location = new System.Drawing.Point(125, 320);
            this.labelShowLogLevel.Name = "labelShowLogLevel";
            this.labelShowLogLevel.Size = new System.Drawing.Size(327, 23);
            this.labelShowLogLevel.TabIndex = 14;
            this.labelShowLogLevel.Text = "standard";
            // 
            // labelLogLevel
            // 
            this.labelLogLevel.AutoSize = true;
            this.labelLogLevel.Location = new System.Drawing.Point(10, 320);
            this.labelLogLevel.Name = "labelLogLevel";
            this.labelLogLevel.Size = new System.Drawing.Size(54, 13);
            this.labelLogLevel.TabIndex = 13;
            this.labelLogLevel.Text = "Log Level";
            // 
            // labelShowPrintHeaders
            // 
            this.labelShowPrintHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPrintHeaders.Location = new System.Drawing.Point(125, 292);
            this.labelShowPrintHeaders.Name = "labelShowPrintHeaders";
            this.labelShowPrintHeaders.Size = new System.Drawing.Size(327, 23);
            this.labelShowPrintHeaders.TabIndex = 12;
            this.labelShowPrintHeaders.Text = "Yes or No";
            // 
            // labelPrintHeaders
            // 
            this.labelPrintHeaders.AutoSize = true;
            this.labelPrintHeaders.Location = new System.Drawing.Point(10, 292);
            this.labelPrintHeaders.Name = "labelPrintHeaders";
            this.labelPrintHeaders.Size = new System.Drawing.Size(109, 13);
            this.labelPrintHeaders.TabIndex = 11;
            this.labelPrintHeaders.Text = "Print DICOM Headers";
            // 
            // labelShowPrinter
            // 
            this.labelShowPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPrinter.Location = new System.Drawing.Point(63, 269);
            this.labelShowPrinter.Name = "labelShowPrinter";
            this.labelShowPrinter.Size = new System.Drawing.Size(389, 23);
            this.labelShowPrinter.TabIndex = 10;
            this.labelShowPrinter.Text = "SelectedPrinter";
            // 
            // labelDisplayPrinter
            // 
            this.labelDisplayPrinter.AutoSize = true;
            this.labelDisplayPrinter.Location = new System.Drawing.Point(10, 269);
            this.labelDisplayPrinter.Name = "labelDisplayPrinter";
            this.labelDisplayPrinter.Size = new System.Drawing.Size(37, 13);
            this.labelDisplayPrinter.TabIndex = 9;
            this.labelDisplayPrinter.Text = "Printer";
            // 
            // labelShowAETitle
            // 
            this.labelShowAETitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowAETitle.Location = new System.Drawing.Point(63, 242);
            this.labelShowAETitle.Name = "labelShowAETitle";
            this.labelShowAETitle.Size = new System.Drawing.Size(389, 23);
            this.labelShowAETitle.TabIndex = 8;
            this.labelShowAETitle.Text = "AETitle";
            // 
            // labelShowPort
            // 
            this.labelShowPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPort.Location = new System.Drawing.Point(63, 219);
            this.labelShowPort.Name = "labelShowPort";
            this.labelShowPort.Size = new System.Drawing.Size(389, 23);
            this.labelShowPort.TabIndex = 7;
            this.labelShowPort.Text = "00000";
            // 
            // labelDisplayAETitle
            // 
            this.labelDisplayAETitle.AutoSize = true;
            this.labelDisplayAETitle.Location = new System.Drawing.Point(10, 243);
            this.labelDisplayAETitle.Name = "labelDisplayAETitle";
            this.labelDisplayAETitle.Size = new System.Drawing.Size(44, 13);
            this.labelDisplayAETitle.TabIndex = 6;
            this.labelDisplayAETitle.Text = "AE Title";
            // 
            // labelDisplayPort
            // 
            this.labelDisplayPort.AutoSize = true;
            this.labelDisplayPort.Location = new System.Drawing.Point(10, 219);
            this.labelDisplayPort.Name = "labelDisplayPort";
            this.labelDisplayPort.Size = new System.Drawing.Size(26, 13);
            this.labelDisplayPort.TabIndex = 5;
            this.labelDisplayPort.Text = "Port";
            // 
            // labelShowIP
            // 
            this.labelShowIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowIP.Location = new System.Drawing.Point(63, 196);
            this.labelShowIP.Name = "labelShowIP";
            this.labelShowIP.Size = new System.Drawing.Size(389, 23);
            this.labelShowIP.TabIndex = 4;
            this.labelShowIP.Text = "0.0.0.0";
            // 
            // labelDisplayIP
            // 
            this.labelDisplayIP.AutoSize = true;
            this.labelDisplayIP.Location = new System.Drawing.Point(10, 197);
            this.labelDisplayIP.Name = "labelDisplayIP";
            this.labelDisplayIP.Size = new System.Drawing.Size(17, 13);
            this.labelDisplayIP.TabIndex = 3;
            this.labelDisplayIP.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.labelAETitle);
            this.groupBox1.Controls.Add(this.textBoxAETitle);
            this.groupBox1.Controls.Add(this.buttonUpdateDICOM);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DICOM Settings";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(7, 45);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(57, 42);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(80, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // labelAETitle
            // 
            this.labelAETitle.AutoSize = true;
            this.labelAETitle.Location = new System.Drawing.Point(7, 19);
            this.labelAETitle.Name = "labelAETitle";
            this.labelAETitle.Size = new System.Drawing.Size(44, 13);
            this.labelAETitle.TabIndex = 2;
            this.labelAETitle.Text = "AE Title";
            // 
            // textBoxAETitle
            // 
            this.textBoxAETitle.Location = new System.Drawing.Point(57, 16);
            this.textBoxAETitle.Name = "textBoxAETitle";
            this.textBoxAETitle.Size = new System.Drawing.Size(514, 20);
            this.textBoxAETitle.TabIndex = 1;
            // 
            // buttonUpdateDICOM
            // 
            this.buttonUpdateDICOM.Location = new System.Drawing.Point(496, 155);
            this.buttonUpdateDICOM.Name = "buttonUpdateDICOM";
            this.buttonUpdateDICOM.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDICOM.TabIndex = 0;
            this.buttonUpdateDICOM.Text = "Update";
            this.buttonUpdateDICOM.UseVisualStyleBackColor = true;
            this.buttonUpdateDICOM.Click += new System.EventHandler(this.buttonUpdateDICOM_Click);
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Image = global::EnDPoINT.Properties.Resources.network_off;
            this.pictureBoxStatus.InitialImage = global::EnDPoINT.Properties.Resources.network_off;
            this.pictureBoxStatus.Location = new System.Drawing.Point(458, 196);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxStatus.TabIndex = 1;
            this.pictureBoxStatus.TabStop = false;
            // 
            // buttonServer
            // 
            this.buttonServer.Location = new System.Drawing.Point(458, 330);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(128, 23);
            this.buttonServer.TabIndex = 0;
            this.buttonServer.Text = "Start EnDPoINT Server";
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Controls.Add(this.buttonPageDown);
            this.tabPagePrint.Controls.Add(this.comboBoxPrintPreviewZoom);
            this.tabPagePrint.Controls.Add(this.buttonPageUp);
            this.tabPagePrint.Controls.Add(this.printPreviewControl);
            this.tabPagePrint.Controls.Add(this.groupBoxPrint);
            this.tabPagePrint.Controls.Add(this.comboBoxPrinters);
            this.tabPagePrint.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrint.Size = new System.Drawing.Size(592, 359);
            this.tabPagePrint.TabIndex = 1;
            this.tabPagePrint.Text = "Printer";
            this.tabPagePrint.UseVisualStyleBackColor = true;
            // 
            // buttonPageDown
            // 
            this.buttonPageDown.Location = new System.Drawing.Point(301, 326);
            this.buttonPageDown.Name = "buttonPageDown";
            this.buttonPageDown.Size = new System.Drawing.Size(75, 23);
            this.buttonPageDown.TabIndex = 6;
            this.buttonPageDown.Text = "<<";
            this.buttonPageDown.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrintPreviewZoom
            // 
            this.comboBoxPrintPreviewZoom.FormattingEnabled = true;
            this.comboBoxPrintPreviewZoom.Location = new System.Drawing.Point(383, 328);
            this.comboBoxPrintPreviewZoom.MaxLength = 4;
            this.comboBoxPrintPreviewZoom.Name = "comboBoxPrintPreviewZoom";
            this.comboBoxPrintPreviewZoom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrintPreviewZoom.TabIndex = 5;
            this.comboBoxPrintPreviewZoom.Text = "30%";
            // 
            // buttonPageUp
            // 
            this.buttonPageUp.Location = new System.Drawing.Point(510, 326);
            this.buttonPageUp.Name = "buttonPageUp";
            this.buttonPageUp.Size = new System.Drawing.Size(75, 23);
            this.buttonPageUp.TabIndex = 3;
            this.buttonPageUp.Text = ">>";
            this.buttonPageUp.UseVisualStyleBackColor = true;
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Location = new System.Drawing.Point(301, 33);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(285, 287);
            this.printPreviewControl.TabIndex = 2;
            // 
            // groupBoxPrint
            // 
            this.groupBoxPrint.Controls.Add(this.checkBoxDICOMHeader);
            this.groupBoxPrint.Location = new System.Drawing.Point(6, 33);
            this.groupBoxPrint.Name = "groupBoxPrint";
            this.groupBoxPrint.Size = new System.Drawing.Size(289, 320);
            this.groupBoxPrint.TabIndex = 1;
            this.groupBoxPrint.TabStop = false;
            this.groupBoxPrint.Text = "Print Settings";
            // 
            // checkBoxDICOMHeader
            // 
            this.checkBoxDICOMHeader.AutoSize = true;
            this.checkBoxDICOMHeader.Location = new System.Drawing.Point(6, 19);
            this.checkBoxDICOMHeader.Name = "checkBoxDICOMHeader";
            this.checkBoxDICOMHeader.Size = new System.Drawing.Size(188, 17);
            this.checkBoxDICOMHeader.TabIndex = 0;
            this.checkBoxDICOMHeader.Text = "include DICOM header information";
            this.checkBoxDICOMHeader.UseVisualStyleBackColor = true;
            this.checkBoxDICOMHeader.CheckedChanged += new System.EventHandler(this.checkBoxDICOMHeader_CheckedChanged);
            // 
            // comboBoxPrinters
            // 
            this.comboBoxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrinters.FormattingEnabled = true;
            this.comboBoxPrinters.Location = new System.Drawing.Point(6, 6);
            this.comboBoxPrinters.Name = "comboBoxPrinters";
            this.comboBoxPrinters.Size = new System.Drawing.Size(580, 21);
            this.comboBoxPrinters.Sorted = true;
            this.comboBoxPrinters.TabIndex = 0;
            this.comboBoxPrinters.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinters_SelectedIndexChanged);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.checkBoxErrorFilter);
            this.tabPageLog.Controls.Add(this.checkBoxFatalFilter);
            this.tabPageLog.Controls.Add(this.checkBoxWarningFilter);
            this.tabPageLog.Controls.Add(this.checkBoxInfoFilter);
            this.tabPageLog.Controls.Add(this.checkBoxDebugFilter);
            this.tabPageLog.Controls.Add(this.button1);
            this.tabPageLog.Controls.Add(this.richTextBox1);
            this.tabPageLog.Controls.Add(this.textBoxLogfile);
            this.tabPageLog.Controls.Add(this.labelLog);
            this.tabPageLog.Controls.Add(this.buttonSetLogfile);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(592, 359);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Logging";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(589, 314);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBoxLogfile
            // 
            this.textBoxLogfile.Enabled = false;
            this.textBoxLogfile.Location = new System.Drawing.Point(51, 6);
            this.textBoxLogfile.Name = "textBoxLogfile";
            this.textBoxLogfile.Size = new System.Drawing.Size(410, 20);
            this.textBoxLogfile.TabIndex = 4;
            this.textBoxLogfile.Text = "C:\\EnDPoINT_log.log";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(3, 8);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(41, 13);
            this.labelLog.TabIndex = 3;
            this.labelLog.Text = "Logfile:";
            // 
            // buttonSetLogfile
            // 
            this.buttonSetLogfile.Location = new System.Drawing.Point(467, 3);
            this.buttonSetLogfile.Name = "buttonSetLogfile";
            this.buttonSetLogfile.Size = new System.Drawing.Size(122, 23);
            this.buttonSetLogfile.TabIndex = 1;
            this.buttonSetLogfile.Text = "Change Logfile...";
            this.buttonSetLogfile.UseVisualStyleBackColor = true;
            // 
            // openFileDialogLogfile
            // 
            this.openFileDialogLogfile.CheckFileExists = false;
            this.openFileDialogLogfile.DefaultExt = "log";
            this.openFileDialogLogfile.FileName = "EnDPoINT";
            this.openFileDialogLogfile.Filter = "Logfiles|*.log|All Files|*.*";
            this.openFileDialogLogfile.InitialDirectory = "C:\\";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(624, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEnDPoINTToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutEnDPoINTToolStripMenuItem
            // 
            this.aboutEnDPoINTToolStripMenuItem.Name = "aboutEnDPoINTToolStripMenuItem";
            this.aboutEnDPoINTToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutEnDPoINTToolStripMenuItem.Text = "&About EnDPoINT";
            // 
            // checkBoxDebugFilter
            // 
            this.checkBoxDebugFilter.AutoSize = true;
            this.checkBoxDebugFilter.Location = new System.Drawing.Point(381, 36);
            this.checkBoxDebugFilter.Name = "checkBoxDebugFilter";
            this.checkBoxDebugFilter.Size = new System.Drawing.Size(64, 17);
            this.checkBoxDebugFilter.TabIndex = 7;
            this.checkBoxDebugFilter.Text = "DEBUG";
            this.checkBoxDebugFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxInfoFilter
            // 
            this.checkBoxInfoFilter.AutoSize = true;
            this.checkBoxInfoFilter.Location = new System.Drawing.Point(294, 36);
            this.checkBoxInfoFilter.Name = "checkBoxInfoFilter";
            this.checkBoxInfoFilter.Size = new System.Drawing.Size(51, 17);
            this.checkBoxInfoFilter.TabIndex = 8;
            this.checkBoxInfoFilter.Text = "INFO";
            this.checkBoxInfoFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxWarningFilter
            // 
            this.checkBoxWarningFilter.AutoSize = true;
            this.checkBoxWarningFilter.Location = new System.Drawing.Point(194, 36);
            this.checkBoxWarningFilter.Name = "checkBoxWarningFilter";
            this.checkBoxWarningFilter.Size = new System.Drawing.Size(60, 17);
            this.checkBoxWarningFilter.TabIndex = 9;
            this.checkBoxWarningFilter.Text = "WARN";
            this.checkBoxWarningFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxFatalFilter
            // 
            this.checkBoxFatalFilter.AutoSize = true;
            this.checkBoxFatalFilter.Location = new System.Drawing.Point(6, 36);
            this.checkBoxFatalFilter.Name = "checkBoxFatalFilter";
            this.checkBoxFatalFilter.Size = new System.Drawing.Size(59, 17);
            this.checkBoxFatalFilter.TabIndex = 10;
            this.checkBoxFatalFilter.Text = "FATAL";
            this.checkBoxFatalFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxErrorFilter
            // 
            this.checkBoxErrorFilter.AutoSize = true;
            this.checkBoxErrorFilter.Location = new System.Drawing.Point(92, 36);
            this.checkBoxErrorFilter.Name = "checkBoxErrorFilter";
            this.checkBoxErrorFilter.Size = new System.Drawing.Size(65, 17);
            this.checkBoxErrorFilter.TabIndex = 11;
            this.checkBoxErrorFilter.Text = "ERROR";
            this.checkBoxErrorFilter.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnDPoINT - Easy Dicom PrINT - v. 0.1 alpha";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDICOM.ResumeLayout(false);
            this.tabPageDICOM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.tabPagePrint.ResumeLayout(false);
            this.groupBoxPrint.ResumeLayout(false);
            this.groupBoxPrint.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServer;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarNetworkCommunication;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDICOM;
        private System.Windows.Forms.TabPage tabPagePrint;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TextBox textBoxLogfile;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonSetLogfile;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogfile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxPrinters;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEnDPoINTToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPrint;
        private System.Windows.Forms.CheckBox checkBoxDICOMHeader;
        private System.Windows.Forms.ComboBox comboBoxPrintPreviewZoom;
        private System.Windows.Forms.Button buttonPageUp;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl;
        private System.Windows.Forms.Button buttonPageDown;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label labelShowPrinter;
        private System.Windows.Forms.Label labelDisplayPrinter;
        private System.Windows.Forms.Label labelShowAETitle;
        private System.Windows.Forms.Label labelShowPort;
        private System.Windows.Forms.Label labelDisplayAETitle;
        private System.Windows.Forms.Label labelDisplayPort;
        private System.Windows.Forms.Label labelShowIP;
        private System.Windows.Forms.Label labelDisplayIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelAETitle;
        private System.Windows.Forms.TextBox textBoxAETitle;
        private System.Windows.Forms.Button buttonUpdateDICOM;
        private System.Windows.Forms.Label labelShowPrintHeaders;
        private System.Windows.Forms.Label labelPrintHeaders;
        private System.Windows.Forms.Label labelShowLogLevel;
        private System.Windows.Forms.Label labelLogLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxErrorFilter;
        private System.Windows.Forms.CheckBox checkBoxFatalFilter;
        private System.Windows.Forms.CheckBox checkBoxWarningFilter;
        private System.Windows.Forms.CheckBox checkBoxInfoFilter;
        private System.Windows.Forms.CheckBox checkBoxDebugFilter;

    }
}


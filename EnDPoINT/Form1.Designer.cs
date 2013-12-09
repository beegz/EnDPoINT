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
            this.tabPagePrint = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.groupBoxLogLevel = new System.Windows.Forms.GroupBox();
            this.radioButtonLogVrb = new System.Windows.Forms.RadioButton();
            this.radioButtonLogStd = new System.Windows.Forms.RadioButton();
            this.radioButtonLogMin = new System.Windows.Forms.RadioButton();
            this.radioButtonLogOff = new System.Windows.Forms.RadioButton();
            this.buttonSetLogfile = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.openFileDialogLogfile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxLogfile = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEnDPoINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPrint = new System.Windows.Forms.GroupBox();
            this.checkBoxDICOMHeader = new System.Windows.Forms.CheckBox();
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.buttonPageUp = new System.Windows.Forms.Button();
            this.comboBoxPrintPreviewZoom = new System.Windows.Forms.ComboBox();
            this.buttonPageDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageDICOM.SuspendLayout();
            this.tabPagePrint.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.groupBoxLogLevel.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.groupBoxPrint.SuspendLayout();
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
            this.tabPageDICOM.Controls.Add(this.button1);
            this.tabPageDICOM.Location = new System.Drawing.Point(4, 22);
            this.tabPageDICOM.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabPageDICOM.Name = "tabPageDICOM";
            this.tabPageDICOM.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabPageDICOM.Size = new System.Drawing.Size(592, 359);
            this.tabPageDICOM.TabIndex = 0;
            this.tabPageDICOM.Text = "DICOM";
            this.tabPageDICOM.UseVisualStyleBackColor = true;
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
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.richTextBox1);
            this.tabPageLog.Controls.Add(this.textBoxLogfile);
            this.tabPageLog.Controls.Add(this.labelLog);
            this.tabPageLog.Controls.Add(this.buttonSetLogfile);
            this.tabPageLog.Controls.Add(this.groupBoxLogLevel);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(592, 359);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Logging";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogLevel
            // 
            this.groupBoxLogLevel.Controls.Add(this.radioButtonLogOff);
            this.groupBoxLogLevel.Controls.Add(this.radioButtonLogMin);
            this.groupBoxLogLevel.Controls.Add(this.radioButtonLogStd);
            this.groupBoxLogLevel.Controls.Add(this.radioButtonLogVrb);
            this.groupBoxLogLevel.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLogLevel.Name = "groupBoxLogLevel";
            this.groupBoxLogLevel.Size = new System.Drawing.Size(586, 54);
            this.groupBoxLogLevel.TabIndex = 0;
            this.groupBoxLogLevel.TabStop = false;
            this.groupBoxLogLevel.Text = "Log Level";
            // 
            // radioButtonLogVrb
            // 
            this.radioButtonLogVrb.AutoSize = true;
            this.radioButtonLogVrb.Location = new System.Drawing.Point(7, 23);
            this.radioButtonLogVrb.Name = "radioButtonLogVrb";
            this.radioButtonLogVrb.Size = new System.Drawing.Size(63, 17);
            this.radioButtonLogVrb.TabIndex = 0;
            this.radioButtonLogVrb.Text = "verbose";
            this.radioButtonLogVrb.UseVisualStyleBackColor = true;
            // 
            // radioButtonLogStd
            // 
            this.radioButtonLogStd.AutoSize = true;
            this.radioButtonLogStd.Checked = true;
            this.radioButtonLogStd.Location = new System.Drawing.Point(172, 23);
            this.radioButtonLogStd.Name = "radioButtonLogStd";
            this.radioButtonLogStd.Size = new System.Drawing.Size(66, 17);
            this.radioButtonLogStd.TabIndex = 1;
            this.radioButtonLogStd.TabStop = true;
            this.radioButtonLogStd.Text = "standard";
            this.radioButtonLogStd.UseVisualStyleBackColor = true;
            // 
            // radioButtonLogMin
            // 
            this.radioButtonLogMin.AutoSize = true;
            this.radioButtonLogMin.Location = new System.Drawing.Point(338, 23);
            this.radioButtonLogMin.Name = "radioButtonLogMin";
            this.radioButtonLogMin.Size = new System.Drawing.Size(59, 17);
            this.radioButtonLogMin.TabIndex = 2;
            this.radioButtonLogMin.Text = "minimal";
            this.radioButtonLogMin.UseVisualStyleBackColor = true;
            // 
            // radioButtonLogOff
            // 
            this.radioButtonLogOff.AutoSize = true;
            this.radioButtonLogOff.Location = new System.Drawing.Point(495, 23);
            this.radioButtonLogOff.Name = "radioButtonLogOff";
            this.radioButtonLogOff.Size = new System.Drawing.Size(37, 17);
            this.radioButtonLogOff.TabIndex = 3;
            this.radioButtonLogOff.Text = "off";
            this.radioButtonLogOff.UseVisualStyleBackColor = true;
            // 
            // buttonSetLogfile
            // 
            this.buttonSetLogfile.Location = new System.Drawing.Point(467, 63);
            this.buttonSetLogfile.Name = "buttonSetLogfile";
            this.buttonSetLogfile.Size = new System.Drawing.Size(122, 23);
            this.buttonSetLogfile.TabIndex = 1;
            this.buttonSetLogfile.Text = "Open Logfile...";
            this.buttonSetLogfile.UseVisualStyleBackColor = true;
            this.buttonSetLogfile.Click += new System.EventHandler(this.buttonSetLogfile_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(4, 68);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(41, 13);
            this.labelLog.TabIndex = 3;
            this.labelLog.Text = "Logfile:";
            this.labelLog.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDialogLogfile
            // 
            this.openFileDialogLogfile.CheckFileExists = false;
            this.openFileDialogLogfile.DefaultExt = "log";
            this.openFileDialogLogfile.FileName = "EnDPoINT";
            this.openFileDialogLogfile.Filter = "Logfiles|*.log|All Files|*.*";
            this.openFileDialogLogfile.InitialDirectory = "C:\\";
            // 
            // textBoxLogfile
            // 
            this.textBoxLogfile.Enabled = false;
            this.textBoxLogfile.Location = new System.Drawing.Point(51, 65);
            this.textBoxLogfile.Name = "textBoxLogfile";
            this.textBoxLogfile.Size = new System.Drawing.Size(410, 20);
            this.textBoxLogfile.TabIndex = 4;
            this.textBoxLogfile.Text = "C:\\EnDPoINT_log.log";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(589, 284);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Location = new System.Drawing.Point(301, 33);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(285, 287);
            this.printPreviewControl.TabIndex = 2;
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
            // buttonPageDown
            // 
            this.buttonPageDown.Location = new System.Drawing.Point(301, 326);
            this.buttonPageDown.Name = "buttonPageDown";
            this.buttonPageDown.Size = new System.Drawing.Size(75, 23);
            this.buttonPageDown.TabIndex = 6;
            this.buttonPageDown.Text = "<<";
            this.buttonPageDown.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabPagePrint.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.groupBoxLogLevel.ResumeLayout(false);
            this.groupBoxLogLevel.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxPrint.ResumeLayout(false);
            this.groupBoxPrint.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxLogLevel;
        private System.Windows.Forms.RadioButton radioButtonLogOff;
        private System.Windows.Forms.RadioButton radioButtonLogMin;
        private System.Windows.Forms.RadioButton radioButtonLogStd;
        private System.Windows.Forms.RadioButton radioButtonLogVrb;
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
        private System.Windows.Forms.Button button1;

    }
}


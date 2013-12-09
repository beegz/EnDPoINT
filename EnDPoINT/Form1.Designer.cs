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
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.groupBoxLogLevel.SuspendLayout();
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
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(600, 404);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageDICOM
            // 
            this.tabPageDICOM.Location = new System.Drawing.Point(4, 22);
            this.tabPageDICOM.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabPageDICOM.Name = "tabPageDICOM";
            this.tabPageDICOM.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabPageDICOM.Size = new System.Drawing.Size(592, 378);
            this.tabPageDICOM.TabIndex = 0;
            this.tabPageDICOM.Text = "DICOM";
            this.tabPageDICOM.UseVisualStyleBackColor = true;
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrint.Size = new System.Drawing.Size(592, 378);
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
            this.tabPageLog.Size = new System.Drawing.Size(592, 378);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.groupBoxLogLevel.ResumeLayout(false);
            this.groupBoxLogLevel.PerformLayout();
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

    }
}


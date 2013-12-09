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
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageLog.SuspendLayout();
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
            this.groupBoxLogLevel.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLogLevel.Name = "groupBoxLogLevel";
            this.groupBoxLogLevel.Size = new System.Drawing.Size(586, 100);
            this.groupBoxLogLevel.TabIndex = 0;
            this.groupBoxLogLevel.TabStop = false;
            this.groupBoxLogLevel.Text = "Log Level";
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

    }
}


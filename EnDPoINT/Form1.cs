using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnDPoINT
{
    public partial class frmMain : Form
    {
        //global vars
        private bool globalStatus;
        private Settings serverSettings;
        private Log serverLog;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.globalStatus = false;
            this.serverSettings = new Settings();

            //update installed printers
            foreach (String s in PrinterSettings.InstalledPrinters)
            {
                this.comboBoxPrinters.Items.Add(s);
            }
            this.updateVisuals();
            this.toolStripStatusLabelServer.Text = "Server is ready to start.";
        }

        private void buttonSetLogfile_Click(object sender, EventArgs e)
        {
            this.openFileDialogLogfile.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void switchStatus()
        {
            globalStatus = !globalStatus;
        }

        private void updateVisuals()
        {
            //general
            this.Icon = Properties.Resources.printer;
            this.toolStripProgressBarNetworkCommunication.Visible = false;

            //Server Start/Stop
            if (globalStatus)
                {
                    this.pictureBoxStatus.Image = Properties.Resources.nework_on;
                    this.buttonServer.Text = "Stop EnDPoINT Server";
                    this.toolStripStatusLabelServer.Text = "Server started...";
                }
            else
                {
                    this.pictureBoxStatus.Image = Properties.Resources.network_off;
                    this.buttonServer.Text = "Start EnDPoINT Server";
                    this.toolStripStatusLabelServer.Text = "Server stopped...";
                }

            //settings
            this.textBoxAETitle.Text = this.serverSettings.AETitle;
            this.textBoxPort.Text = this.serverSettings.serverPort.ToString();
            this.labelShowIP.Text = this.serverSettings.serverIP.ToString();
            this.labelShowPort.Text = this.serverSettings.serverPort.ToString();
            this.labelShowAETitle.Text = this.serverSettings.AETitle;
            this.labelShowPrinter.Text = this.serverSettings.Printer;
            this.checkBoxDICOMHeader.Checked = this.serverSettings.PrintHeader;
            if (this.serverSettings.PrintHeader)
            {
                this.labelShowPrintHeaders.Text = "Yes";
            }
            else
            {
                this.labelShowPrintHeaders.Text = "No";
            }
            switch (this.serverSettings.LogLevel)
            {
                case 0:
                    this.labelShowLogLevel.Text = "off";
                    break;
                case 1:
                    this.labelShowLogLevel.Text = "minimal";
                    break;
                case 2:
                    this.labelShowLogLevel.Text = "standard";
                    break;
                case 3:
                    this.labelShowLogLevel.Text = "verbose";
                    break;
            }
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            switchStatus();
            updateVisuals();
        }

        private void comboBoxPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.serverSettings.Printer = this.comboBoxPrinters.SelectedItem.ToString();
            this.toolStripStatusLabelServer.Text = "Printer settings updated. Restart server to apply.";
        }

        private void checkBoxDICOMHeader_CheckedChanged(object sender, EventArgs e)
        {
            this.serverSettings.PrintHeader = this.checkBoxDICOMHeader.Checked;
            this.toolStripStatusLabelServer.Text = "DICOM print header settings updated. Restart server to apply.";
        }

        private void radioButtonLogStd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonLogStd.Checked)
            {
                this.serverSettings.LogLevel = 2;
                this.toolStripStatusLabelServer.Text = "Loglevel settings updated. Restart server to apply.";
            }
        }

        private void radioButtonLogVrb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonLogVrb.Checked)
            {
                this.serverSettings.LogLevel = 3;
                this.toolStripStatusLabelServer.Text = "Loglevel settings updated. Restart server to apply.";
            }
        }

        private void radioButtonLogMin_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonLogMin.Checked)
            {
                this.serverSettings.LogLevel = 1;
                this.toolStripStatusLabelServer.Text = "Loglevel settings updated. Restart server to apply.";
            }
        }

        private void radioButtonLogOff_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonLogOff.Checked)
            {
                this.serverSettings.LogLevel = 0;
                this.toolStripStatusLabelServer.Text = "Loglevel settings updated. Restart server to apply.";
            }
        }

        private void buttonUpdateDICOM_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabelServer.Text = "DICOM settings updated. Restart server to apply.";
            this.serverSettings.AETitle = this.textBoxAETitle.Text;
            this.serverSettings.serverPort = Convert.ToInt32(this.textBoxPort.Text);
        }
    }
}

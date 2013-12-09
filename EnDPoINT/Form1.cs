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
            this.updateVisuals();
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
            //this.labelShowIP = this.serverSettings
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            switchStatus();
        }
    }
}

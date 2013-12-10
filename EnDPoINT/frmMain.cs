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

using log4net;
using ClearCanvas.Dicom;
using ClearCanvas.Dicom.Network;

namespace EnDPoINT
{
    public partial class frmMain : Form
    {
        //global vars
        private bool _globalStatus;
        private Settings _serverSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        /// <summary>
        /// Main init
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Init vars on load for basic application setup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //setup log4net
            log4net.Config.XmlConfigurator.Configure();
            
            //setup globals
            this._globalStatus = false;
            this._serverSettings = new Settings();
            _serverSettings.spoolDir = Application.StartupPath.ToString() + "\\spool\\";

            //update installed printers
            foreach (string s in PrinterSettings.InstalledPrinters)
            {
                this.comboBoxPrinters.Items.Add(s);
            }
            this.textBoxAETitle.Text = this._serverSettings.AETitle;
            this.textBoxPort.Text = this._serverSettings.serverPort.ToString();
            this.textBoxSpoolDir.Text = this._serverSettings.spoolDir;

            this.updateStatus();
            this.updateVisuals();

            this.toolStripStatusLabelServer.Text = "Server is ready to start.";
            log.Info("EnDPoINT DICOM printserver started");
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Switch the server status on/off
        /// </summary>
        private void switchStatus()
        {
            _globalStatus = !_globalStatus;
        }

        /// <summary>
        /// Update all visuals to current settings
        /// </summary>
        private void updateStatus()
        {
            //general
            this.Icon = Properties.Resources.printer;
            this.toolStripProgressBarNetworkCommunication.Visible = false;

            //Server Start/Stop
            if (_globalStatus)
                {
                    this.pictureBoxStatus.Image = Properties.Resources.nework_on;
                    this.buttonServer.Text = "Stop EnDPoINT Server";
                    this.toolStripStatusLabelServer.Text = "Server started...";
                    dcmServer.StoragePath = this._serverSettings.spoolDir;
                    dcmServer.StartListening(this._serverSettings.AETitle, this._serverSettings.serverIP ,this._serverSettings.serverPort);
                    log.Info("DICOM server started.");
                }
            else
                {
                    this.pictureBoxStatus.Image = Properties.Resources.network_off;
                    this.buttonServer.Text = "Start EnDPoINT Server";
                    this.toolStripStatusLabelServer.Text = "Server stopped...";
                    dcmServer.StopListening(this._serverSettings.serverPort);
                    log.Info("DICOM server stopped.");
                }
        }

        private void updateVisuals()
        {
            this.labelShowPrinter.Text = this._serverSettings.Printer;
            if (this._serverSettings.PrintHeader)
            {
                this.labelShowPrintHeaders.Text = "Yes";
            }
            else
            {
                this.labelShowPrintHeaders.Text = "No";
            }
            this.labelShowIP.Text = this._serverSettings.serverIP.ToString();
            this.labelShowPort.Text = this._serverSettings.serverPort.ToString();
            this.labelShowAETitle.Text = this._serverSettings.AETitle;
        }

        # region UIAction
        /// <summary>
        /// Activate/Deactivate server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServer_Click(object sender, EventArgs e)
        {
            switchStatus();
            updateStatus();
        }

        
        private void comboBoxPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._serverSettings.Printer = this.comboBoxPrinters.SelectedItem.ToString();
            this.toolStripStatusLabelServer.Text = "Printer settings updated. Restart server to apply.";
            this.updateVisuals();
            log.Info("Printer selected: " + this._serverSettings.Printer);
        }

        private void checkBoxDICOMHeader_CheckedChanged(object sender, EventArgs e)
        {
            this._serverSettings.PrintHeader = this.checkBoxDICOMHeader.Checked;
            this.toolStripStatusLabelServer.Text = "DICOM print header settings updated. Restart server to apply.";
            this.updateVisuals();
            log.Info("Changed the print DICOM header setting."); 
        }

     private void buttonUpdateDICOM_Click(object sender, EventArgs e)
        {
            this._serverSettings.AETitle = this.textBoxAETitle.Text;
            this._serverSettings.serverPort = Convert.ToInt32(this.textBoxPort.Text);
            this.toolStripStatusLabelServer.Text = "DICOM settings updated. Restart server to apply.";
            this.updateVisuals();
            log.Info("DICOM config updated.");
        }
        #endregion

    }
}

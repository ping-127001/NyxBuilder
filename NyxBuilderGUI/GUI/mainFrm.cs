using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NyxBuilderGUI.Handler;

namespace NyxBuilderGUI.GUI
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            FontChecker.checkFont();
            winrarChecker.checkIfPackaged();
            Discord.Start();
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Discord.Close();
            Close();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            var settings = new settingsFrm();
            settings.Show();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

        }

        private void windowsBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                BuildNyx.buildNyx("win32");
                Discord.Update("Built Nyx for Windows");
            }
        }

        private void macBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                BuildNyx.buildNyx("mas");
                Discord.Update("Built Nyx for Mac");
            }
        }

        private void linuxBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                BuildNyx.buildNyx("linux");
                Discord.Update("Built Nyx for Linux");
            }
        }

        private void darwinBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                BuildNyx.buildNyx("darwin");
                Discord.Update("Built Nyx for Darwin");
            }
        }
    }
}

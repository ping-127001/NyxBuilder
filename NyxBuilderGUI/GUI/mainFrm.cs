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
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
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
                NyxBuilder.buildNyx("win32");
            }
        }

        private void macBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                NyxBuilder.buildNyx("mas");
            }
        }

        private void linuxBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                NyxBuilder.buildNyx("linux");
            }
        }

        private void darwinBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                NyxBuilder.buildNyx("darwin");
            }
        }
    }
}

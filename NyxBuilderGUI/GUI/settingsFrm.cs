﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxBuilderGUI.GUI
{
    public partial class settingsFrm : Form
    {
        public settingsFrm()
        {
            InitializeComponent();
        }

        private void settingsFrm_Load(object sender, EventArgs e)
        {

            if (Directory.Default.nyxSrc.Length < 1)
            {

            }
            else
            {
                srcTextBox.Text = Directory.Default.nyxSrc;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (srcTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please enter Nyx's source directory", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Directory.Default.nyxSrc = srcTextBox.Text;
                Directory.Default.Save();
                MessageBox.Show("Saved directory", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
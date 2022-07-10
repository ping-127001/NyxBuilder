using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxBuilderGUI.Handler
{
    internal class NodeJSChecker
    {
        public static void isNodeInstalled()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
                proc.StartInfo.Arguments = $"/c node -v";
                proc.Start();
                string output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();

                if (output.Contains("'node' is not recognized as an internal or external command"))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes", "Would you like to recheck if NodeJS is installed?", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        isNodeInstalled();
                    }
                }
                else
                {
                    Data.nodeInsatlled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error checking if you have NodeJS installed. We are assuming it is installed. Error: {ex.Message}", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Data.nodeInsatlled = true;
            }
        }

        public static void isElectronPackagerInstalled()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
                proc.StartInfo.Arguments = $"/c npm list -g --depth 0";
                proc.Start();
                string output = proc.StandardOutput.ReadToEnd();
                proc.WaitForExit();

                if (!output.Contains("-- electron-packager"))
                {
                    MessageBox.Show($"electron-packager is not installed, this is required to build Nyx", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Data.electronPackagerInstalled = false;
                }

                else
                {
                    Data.electronPackagerInstalled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error checking if you have electron-packager installed. We are assuming it is installed. Error: {ex.Message}", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Data.electronPackagerInstalled = true;
            }
        }
    }
}
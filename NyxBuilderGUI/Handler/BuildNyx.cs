using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxBuilderGUI.Handler
{
    internal class BuildNyx
    {
        public static void buildNyx(string Platform)
        {
            if (Data.nodeInsatlled)
            {
                if (Data.electronPackagerInstalled)
                {
                    try
                    {
                        //Building for mac requires command prompt to run as admin
                        if (Platform == "mas")
                        {
                            System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                            proc.CreateNoWindow = true;
                            proc.FileName = @"C:\windows\system32\cmd.exe";
                            //Building for Mac requires admin so start console as admin
                            proc.UseShellExecute = true;
                            proc.Verb = "runas";
                            proc.Arguments = $"/c npx electron-packager {Directory.Default.nyxSrc}  Nyx --platform={Platform}";
                            System.Diagnostics.Process.Start(proc);
                        }
                        else
                        {
                            System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                            proc.CreateNoWindow = true;
                            proc.FileName = @"C:\windows\system32\cmd.exe";
                            proc.Arguments = $"/c npx electron-packager {Directory.Default.nyxSrc}  Nyx --platform={Platform}";
                            System.Diagnostics.Process.Start(proc);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"There was an error building Nyx from source. Exception: {ex.Message}", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (!Data.nodeInsatlled)
            {
                MessageBox.Show($"NodeJS is not installed, Nyx build has failed", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!Data.electronPackagerInstalled)
            {
                MessageBox.Show($"electron-packager is not installed, Nyx build has failed", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
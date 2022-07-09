using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxBuilderGUI.Handler
{
    internal class winrarChecker
    {
        public static void checkIfPackaged()
        {
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Nyx Builder cannot be run from WinRAR Please extract to a folder and try again.", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
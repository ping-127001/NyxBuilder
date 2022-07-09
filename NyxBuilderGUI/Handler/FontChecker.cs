using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxBuilderGUI.Handler
{
    internal class FontChecker
    {
        public static void checkFont()
        {
            string fontName = "badcache";
            float fontSize = 12;

            using (Font fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                if (fontTester.Name != fontName)
                {
                    MessageBox.Show("badcache font not installed, please install badcache", "Nyx Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }
    }
}
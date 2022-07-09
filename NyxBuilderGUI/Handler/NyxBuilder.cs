﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyxBuilderGUI.Handler
{
    internal class NyxBuilder
    {
        public static void buildNyx(string Platform)
        {
            //Building for mac requires command prompt to run as admin
            if (Platform == "mas")
            {
                System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
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
                proc.FileName = @"C:\windows\system32\cmd.exe";
                proc.Arguments = $"/c npx electron-packager {Directory.Default.nyxSrc}  Nyx --platform={Platform}";
                System.Diagnostics.Process.Start(proc);
            }
        }
    }
}

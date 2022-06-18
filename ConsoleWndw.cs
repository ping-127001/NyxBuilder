using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyxBuilder.Handler;

namespace NyxBuilder
{
    internal class ConsoleWndw
    {
        static void Main(string[] args)
        {
            Startup();
            Options();
        }

        static void Startup()
        {
            Console.BufferWidth = Console.WindowWidth = 110;
            Console.BufferHeight = Console.WindowHeight = 28;
            Console.Title = "Nyx Builder";
            WindowUtility.MoveWindowToCenter();
        }

        static void WarnMessage(string Text)
        {
            WindowUtility.centerText(Text);
        }

        static void Options()
        {
            Writer.resetOptions();
            Console.Clear();
            Writer.printAscii();
            Console.WriteLine("");
            Console.WriteLine("");
            WarnMessage($"MAKE SURE YOU HAVE electron-packager INSTALLED IN NYX SOURCE FOLDER");
            Console.WriteLine("");
            Writer.optionsWriter("Build for Windows");
            Writer.optionsWriter("Build for Mac");
            Writer.optionsWriter("Build for Linux");
            Writer.optionsWriter("Build for Darwin");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    try
                    {
                        Console.Clear();
                        WindowUtility.centerText("Please select Nyx source directory");
                        var dir = Console.ReadLine();
                        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = $"/c npx electron-packager {dir}  Nyx --platform=win32";
                        System.Diagnostics.Process.Start(proc);
                        Console.WriteLine("");
                        Writer.resetOptions();
                        Writer.optionsWriter("Menu");

                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        WindowUtility.centerText("There was an error building Nyx");
                        Console.WriteLine($"Error: " + ex);
                        Writer.optionsWriter("Menu");
                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    break;

                case "2":
                    try
                    {
                        Console.Clear();
                        WindowUtility.centerText("Please select Nyx source directory");
                        var dir = Console.ReadLine();
                        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = $"/c npx electron-packager {dir}  Nyx --platform=mac";
                        System.Diagnostics.Process.Start(proc);
                        Console.WriteLine("");
                        Writer.resetOptions();
                        Writer.optionsWriter("Menu");

                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        WindowUtility.centerText("There was an error building Nyx");
                        Console.WriteLine($"Error: " + ex);
                        Writer.optionsWriter("Menu");
                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    break;


                case "3":
                    try
                    {
                        Console.Clear();
                        WindowUtility.centerText("Please select Nyx source directory");
                        var dir = Console.ReadLine();
                        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = $"/c npx electron-packager {dir}  Nyx --platform=mas";
                        System.Diagnostics.Process.Start(proc);
                        Console.WriteLine("");
                        Writer.resetOptions();
                        Writer.optionsWriter("Menu");

                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        WindowUtility.centerText("There was an error building Nyx");
                        Console.WriteLine($"Error: " + ex);
                        Writer.optionsWriter("Menu");
                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    break;

                case "4":
                    try
                    {
                        Console.Clear();
                        WindowUtility.centerText("Please select Nyx source directory");
                        var dir = Console.ReadLine();
                        System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = $"/c npx electron-packager {dir}  Nyx --platform=darwin";
                        System.Diagnostics.Process.Start(proc);
                        Console.WriteLine("");
                        Writer.resetOptions();
                        Writer.optionsWriter("Menu");

                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        WindowUtility.centerText("There was an error building Nyx");
                        Console.WriteLine($"Error: " + ex);
                        Writer.optionsWriter("Menu");
                        Writer.resetOptions();
                        Console.ReadLine();
                        Options();
                    }
                    break;

                default:
                    Options();
                    break;
            }
        }
    }
}

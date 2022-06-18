using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyxBuilder.Handler;

namespace NyxBuilder.Handler
{
    internal class Writer
    {
        public static int options = 0;

        public static void optionsWriter(string text)
        {
            options++;
            Console.WriteLine($"{options}.) {text}");
        }

        public static void resetOptions()
        {
            options = 0;
        }

        public static void printAscii()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            WindowUtility.centerText(" __  ___   ___   __  __ _  _ _ _   __  ___ ___ ");
            WindowUtility.centerText(@"|  \| \ `v' | \_/ / |  \ || | | | | _\| __| _ \");
            WindowUtility.centerText(@"| | ' |`. .' > , <  | -< \/ | | |_| v | _|| v / ");
            WindowUtility.centerText(@"|_|\__| !_! /_/ \_\ |__/\__/|_|___|__/|___|_|_\ ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

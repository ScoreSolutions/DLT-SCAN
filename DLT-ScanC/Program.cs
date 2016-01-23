using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Func.Utilities;

namespace DLT_ScanC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            if (System.IO.File.Exists(Config.ConfigFlieName) == false) {
                Config.CreateNewConfig();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmScanProcess2());
            //Application.Run(new frmDocType());
        }

        //public const string ConfigFlieName  = @"C:\Windows\DLT-Config.ini";
    }
}

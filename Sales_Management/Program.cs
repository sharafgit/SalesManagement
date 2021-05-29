using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // نقطة البداية عند تنفيذ البرنامج
            Application.Run(new PL.FRM_MAIN());
        }
    }
}

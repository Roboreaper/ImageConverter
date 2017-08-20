using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter
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

            if (!Debugger.IsAttached)
            {
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnCurrentDomain_UnhandledException);
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            }
            Application.Run(new FormImageConvert());
        }

        private static void OnCurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"Something went wrong.\r\n Stack:{  Environment.StackTrace}\r\n Ex:" + e.ExceptionObject.ToString());          
        }
    }
}

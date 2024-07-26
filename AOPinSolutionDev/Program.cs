#region Namespace Imports


using System;
using System.Windows.Forms;
using AOPinSolutionDev.Forms;


#endregion Namespace Imports


namespace AOPinSolutionDev
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

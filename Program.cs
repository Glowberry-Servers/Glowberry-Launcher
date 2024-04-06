using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using glowberry.common;
using glowberry.ui.graphical;

namespace glowberry
{
    internal static class Program
    {
        /// <summary>
        /// Get the program version for the DLL unless an override is specified, otherwise use its value.
        /// </summary>
        public static string Version
        {
            get
            {
                string over = ConfigurationManager.AppSettings.Get("Version.App.Override");
                return over == "disabled" ? GlobalVersionManager.GetVersion("launcher") : over;
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logging.Logger.LoggingFilePath = Path.Combine(Constants.FileSystem.AddSection("logs").SectionFullPath, Logging.Logger.LoggingSession + ".log");

            try
            {
                Application.Run(new PreLoadingScreen());
                Application.Run(new LoadingScreen());
                Application.Run(Mainframe.INSTANCE);
            }
            
            // Logs whatever fatal issue happens as a last resource.
            catch (ConfigurationException e)
            {
                Logging.Logger.Fatal(@"An unexpected error occured and the program was forced to exit.");
                Logging.Logger.Fatal(e.Message + "\n" + e.StackTrace, LoggingType.File);
            }
        }
        
    }
}
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using glowberry.common;
using glowberry.common.configuration;
using glowberry.ui.graphical;

namespace glowberry
{
    internal static class Program
    {
        /// <summary>
        /// Get the program version from the DLL unless an override is specified, otherwise use its value.
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
            AppDomain.CurrentDomain.UnhandledException += FatalExceptionHandler;
            Application.ThreadException += FatalExceptionHandler;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            
            try
            {
                Logging.Logger.LoggingFilePath = Path.Combine(Constants.FileSystem.AddSection("logs").SectionFullPath, Logging.Logger.LoggingSession + ".log");
                Logging.MinimumConsoleLoggingLevel = LoggingLevel.Info;
                Logging.MinimumFileLoggingLevel = LoggingLevel.Debug;
                LogComputerInformation();
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            
                Application.Run(new PreLoadingScreen());
                Application.Run(new LoadingScreen());
                Application.Run(new Mainframe());
            }
            catch (Exception e) { FatalExceptionHandler(null, e.ToString()); }
        }
        
        /// <summary>
        /// Logs the computer information to the log file.
        /// </summary>
        static void LogComputerInformation()
        {
            Logging.Logger.Info("Starting launcher session logging.");
            Logging.Logger.Info($"Glowberry Launcher Version: {Version}");
            Logging.Logger.Info($"DLL Version: {GlobalVersionManager.GetVersion("dll")}");
            Logging.Logger.Info($"User Domain Name: {Environment.UserDomainName}");
            Logging.Logger.Info($"User Name: {Environment.UserName}");
            Logging.Logger.Info($"Process ID: {Process.GetCurrentProcess().Id}");
            Logging.Logger.Info($"OS Version: {Environment.OSVersion.Platform} {Environment.OSVersion}");
            Logging.Logger.Info($"Available RAM Memory: {Environment.WorkingSet / 1024 / 1024} MB");
            Logging.Logger.Info($"Available Logical Processors: {Environment.ProcessorCount}");
        }
        
        /// <summary>
        /// Handles the fatal exceptions that occur in the program for any unhandled exceptions.
        /// Captures the entire stack trace and logs it to the log file.
        /// </summary>
        static void FatalExceptionHandler(object sender, UnhandledExceptionEventArgs e) => 
            FatalExceptionHandler(sender, e.ExceptionObject.ToString());
        
        /// <summary>
        /// Handles the thread exceptions that occur in the program for any unhandled exceptions.
        /// </summary>
        static void FatalExceptionHandler(object sender, ThreadExceptionEventArgs e) => 
            FatalExceptionHandler(sender, e.Exception.ToString());
        
        /// <summary>
        /// Handles the fatal exceptions that occur in the program. This will log the error and prompt the user to open the
        /// log file.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="errorMessage">The error message to be printed in the file</param>
        static void FatalExceptionHandler(object sender, string errorMessage)
        {
            // A failsafe to ensure that the error message is always logged.
            string fatalErrorsPath = Path.GetDirectoryName(Application.ExecutablePath) + "/fatal.log";
            File.WriteAllText(fatalErrorsPath, errorMessage);
            
            Logging.Logger.Fatal(@"An unexpected error occured and the program was forced to exit.");
            Logging.Logger.Fatal(errorMessage, LoggingType.File);

            // Prompt the user to open the log file.
            string message = "A fatal error has occured and the program was forced to exit.\nWould you like to open the log file?";
            DialogResult result = MessageBox.Show(message, @"Glowberry - Fatal Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            
            if (result == DialogResult.Yes) Process.Start(Logging.Logger.LoggingFilePath);
        }
    }
}
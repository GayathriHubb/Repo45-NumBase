using System;
using System.IO;
using System.Windows.Forms;

namespace NumberBaseConverter
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (Sender, E) =>
            {
                LogException(E.Exception);
                MessageBox.Show(
                    $"An unexpected error occurred:\n\n{E.Exception.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (Sender, E) =>
            {
                if (E.ExceptionObject is Exception Ex)
                {
                    LogException(Ex);
                }
            };

            ApplicationConfiguration.Initialize();
            Application.Run(new FormNumBase());
        }

        private static void LogException(Exception Ex)
        {
            try
            {
                string LogPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "nbc_exceptions.log");

                File.AppendAllText(LogPath,
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]{Environment.NewLine}" +
                    $"{Ex}{Environment.NewLine}{Environment.NewLine}");
            }
            catch { }
        }
    }
}

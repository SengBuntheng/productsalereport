using System;
using System.IO;
using System.Security.Principal;

namespace productsalereport.src.Config
{
    public static class ErrorLogger
    {
        private static readonly string ProjectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
        private static readonly string LogDirectory = Path.Combine(ProjectRoot, "logs");
        private static readonly string LogFilePath = Path.Combine(LogDirectory, "errors.txt");

        public static void Log(Exception ex)
        {
            Log(ex.ToString());
        }

        public static void Log(string message)
        {
            try
            {
                // Ensure /src/logs exists
                if (!Directory.Exists(LogDirectory))
                {
                    Directory.CreateDirectory(LogDirectory);
                }

                string user = Environment.UserName;
                string machine = Environment.MachineName;
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string logEntry = $@"[{timestamp}] [User: {user}] [Machine: {machine}]
                Error: {message}
                --------------------------------------------------{Environment.NewLine}";
                File.AppendAllText(LogFilePath, logEntry);
            }
            catch (Exception logEx)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Logging failed:\n{logEx.Message}",
                    "Log Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
            }
        }

        public static string GetLogPath() => LogFilePath;
    }
}

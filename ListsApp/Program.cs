using System.Globalization;
using System.Net;
using System.Security.Cryptography;

namespace ListsApp
{
    internal class Program

    {
        public interface ILogger
        {
            void Log(string message);
        }

        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.doWork();

            ILogger dbLogger = new DataBaseLogger();
            app = new Application(dbLogger);
            app.doWork();
        }

        public class FileLogger : ILogger
        {
            public void Log(string message)
            {
                string dirPath = @"C:\Logs";
                string filePath = Path.Combine(dirPath, "log.txt");

                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                File.AppendAllText(filePath, message + "\n");
            }
        }
        public class DataBaseLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Logging to DB. {message}");
            }


        }

        public class Application
        {
            private readonly ILogger _logger;

            public Application(ILogger logger)
            {
                _logger = logger;
            }

            public void doWork()
            {
                _logger.Log("Starting the work");
                _logger.Log("Finishing");
            }

        }
    }
}

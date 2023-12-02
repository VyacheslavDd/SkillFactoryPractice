using Microsoft.AspNetCore.Mvc;

namespace MVCAuthentication
{
    public class Logger : ILogger
    {
        private string? directoryName;
        private string? eventsFilePath;
        private string? errorsFilePath;

        public Logger()
        {
            directoryName = "Log_" + DateTime.Now.Ticks.ToString();
            Directory.CreateDirectory(directoryName);
            eventsFilePath = Path.Combine(directoryName, "events.txt");
            errorsFilePath = Path.Combine(directoryName, "errors.txt");
        }

        private static async Task WriteToFile(string? filePath, string message)
        {
            await File.AppendAllTextAsync(filePath, message + "\n");
        }

        public async Task WriteEvent(string eventMessage)
        {
            Console.WriteLine(eventMessage);
            await WriteToFile(eventsFilePath, eventMessage);
        }

        public async Task WriteError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            await WriteToFile(errorsFilePath, errorMessage);
        }
    }
}

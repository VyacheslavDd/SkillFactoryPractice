using MVCWebAppTest.Models.db;
using MVCWebAppTest.Repositories.RequestRepository;

namespace WebApplicationTesting
{
    public class LoggingMiddleware
    {
        private RequestDelegate next;
        private IRequestRepository requestRepository;

        public LoggingMiddleware(RequestDelegate next, IRequestRepository repository)
        {
            this.next = next;
            this.requestRepository = repository;
        }

        private async Task AddLogToFile(string phrase)
        {
            var filePath = Path.Combine("Additional Files", "RequestLog.txt");
            using (var sw = File.AppendText(filePath))
            {
                await sw.WriteLineAsync(phrase);
            }
        }

        private async Task LogRequestToDatabase(string phrase)
        {
            var request = new Request() { Id = Guid.NewGuid(), Url = phrase, Date = DateTime.Now };
            await requestRepository.AddRequest(request);
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string phrase = $"Redirecting to next page {context.Request.Host.Value + context.Request.Path}";
            await LogRequestToDatabase(phrase);
            Console.WriteLine(phrase);
            await next.Invoke(context);
        }
    }
}

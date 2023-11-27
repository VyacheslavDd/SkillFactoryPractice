namespace WebApplicationTesting
{
    public class LoggingMiddleware
    {
        private RequestDelegate next;

        public LoggingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        private async Task AddLogToFile(string phrase)
        {
            var filePath = Path.Combine("Additional Files", "RequestLog.txt");
            using (var sw = File.AppendText(filePath))
            {
                await sw.WriteLineAsync(phrase);
            }
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string phrase = $"Redirecting to next page {context.Request.Host.Value + context.Request.Path}";
            await AddLogToFile(phrase);
            Console.WriteLine(phrase);
            await next.Invoke(context);
        }
    }
}

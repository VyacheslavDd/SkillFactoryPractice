namespace MVCAuthentication
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _logger.WriteEvent($"Я твой Middleware. Твой IP: {httpContext.Connection.LocalIpAddress}");
            await _next.Invoke(httpContext);
        }
    }
}

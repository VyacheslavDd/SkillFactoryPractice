namespace WebApplicationTesting
{
    public class PageNotFoundMiddleware
    {
        private RequestDelegate next;

        public PageNotFoundMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            await next.Invoke(context);

            if (context.Response.StatusCode == 404)
                await context.Response.WriteAsync("Page not found!");
        }
    }
}

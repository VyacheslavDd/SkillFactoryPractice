using WebApplicationTesting;

WebApplicationOptions options = new WebApplicationOptions() { WebRootPath = "Views" };
var builder = WebApplication.CreateBuilder(options);
var app = builder.Build();
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
    app.UseDeveloperExceptionPage();

app.UseStaticFiles();
app.UseRouting();

app.UseMiddleware(typeof(LoggingMiddleware));
app.UseMiddleware(typeof(PageNotFoundMiddleware));

app.Map("/", () => "Hello!");
app.Map("/about", About);
app.Map("/config", Config);

app.Run();

static void About(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync($"It's all about my website.");
    });
}

static void Config(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync($"is all you need to know!");
    });
}


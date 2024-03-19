

using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello");
    await next(context);
});

app.UseMyCustomMiddleware();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello again again");
});
app.Run();
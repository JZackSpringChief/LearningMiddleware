

using MiddlewareExample.CustomMiddleware;
using refreashOnCsharp.CustomMiddlewar;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello\n");
    await next(context);
});

//app.UseMyCustomMiddleware();
app.UseHelloCustomMiddleware();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello again again\n");
});
app.Run();
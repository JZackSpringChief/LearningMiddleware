
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enabled routing
app.UseRouting();

//created endpoints
app.UseEndpoints(endpoints =>
{
    endpoints.Map("daily-digest-report{reportdate:datetime}", async context =>
       {
           if (context.Request.RouteValues.ContainsKey("reportdate"))
           {
               DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
               await context.Response.WriteAsync($"In daily-digest-report: {reportDate.ToShortDateString()}");
           }
           else
           {
               await context.Response.WriteAsync("reportdate not provided");
           }
       });


});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enabled routing
app.UseRouting();

//created endpoints
app.UseEndpoints(async endpoints =>
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

    endpoints.Map("cities/{cityid:guid}", async context =>
        {
            Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
            await context.Response.WriteAsync($"City Info: {cityId}");
        });
    endpoints.Map("sales-report/{year:int:min(1900)}/{month:regex(^(apr|jul|oct|jan)$)}", async context =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);

        await context.Response.WriteAsync($"sales report - {year} - {month}");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
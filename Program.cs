
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enabled routing
app.UseRouting();

//created endpoints
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/files/{filename}.{extension}", async
    context =>
    {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In files --- filename: {filename} --- extension: {extension}");
    });

    endpoints.Map("employee/profile/{EmployeeName=KylieIsACutie}", async
        context =>
        {
            string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
            await context.Response.WriteAsync($"In Employee profile: {employeeName}");
        });

    endpoints.Map("products/details/{id?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Product details: {id}");
        }
        else
        {
            await context.Response.WriteAsync($"Product details: id is not supplied");
        }
    });

});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
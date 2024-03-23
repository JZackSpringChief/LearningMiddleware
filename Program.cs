var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllers().AddXmlDataContractSerializerFormatters(); //used by about 1% of the time
var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();
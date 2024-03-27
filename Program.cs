using ServiceContracts;
using Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(
        typeof(ICitiesService),
        typeof(CitiesService),
        ServiceLifetime.Transient
        ));

builder.Services.AddControllers();
//builder.Services.AddControllers().AddXmlDataContractSerializerFormatters(); //used by about 1% of the

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
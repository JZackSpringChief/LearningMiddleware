// using Microsoft.Extensions.Primitives;

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.Run(async (HttpContext context) =>
// {
//     StreamReader reader = new StreamReader(context.Request.Body);
//     string body = await reader.ReadToEndAsync();

//     Dictionary<string, StringValues> qDict =
//     Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery
//     (body);

//     if (qDict.ContainsKey("firstName"))
//     {
//         string? firstName = qDict["firstName"];
//         await context.Response.WriteAsync(firstName);

//         foreach (var name in firstName)
//         {
//             await context.Response.WriteAsync(name);
//         }
//     }
// });

// app.Run();
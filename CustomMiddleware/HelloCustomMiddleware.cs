
// namespace refreashOnCsharp.CustomMiddlewar;

// public class HelloCustomMiddleware
// {
//     private readonly RequestDelegate _next;
//     public HelloCustomMiddleware(RequestDelegate next)
//     {
//         _next = next;
//     }
//     public async Task Invoke(HttpContext httpContext)
//     {
//         if (httpContext.Request.Query.ContainsKey("firstname") &&
//             httpContext.Request.Query.ContainsKey("lastname"))
//         {
//             string fullName = httpContext.Request.Query["firstname"]
//                 + " " +
//                     httpContext.Request.Query["lastname"];
//             await httpContext.Response.WriteAsync(fullName);
//         }
//         await _next(httpContext);
//     }
// }

// public static class HelloCustomMiddlewareExtenstions
// {
//     public static IApplicationBuilder UseHelloCustomMiddleware(this IApplicationBuilder builder)
//     {
//         return builder.UseMiddleware<HelloCustomMiddleware>();
//     }
// }
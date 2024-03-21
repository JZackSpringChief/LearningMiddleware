
using Microsoft.AspNetCore.Mvc;

namespace refreashOnCsharp.Controllers;

//[Route("[controller]")]
[Controller]
public class HomeController : Controller
{
    [Route("home")]
    [Route("/")]
    public ContentResult Index()
    {
        // return new ContentResult() { Content = "Hello from index", ContentType = "text/plain" };
        //return Content("Hello from Index", "text/plain");
        return Content("<h1>Welcome<h1/> <h2>Hello from Index</h2>", "text/html");
    }

    [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]

    public string Contact()
    {
        return "Hello from Contact";
    }

    [Route("About")]

    public string About()
    {
        return "Hello from About";
    }
}

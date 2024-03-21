
using Microsoft.AspNetCore.Mvc;

namespace refreashOnCsharp.Controllers;

//[Route("[controller]")]
public class HomeController : Controller
{
    [Route("home")]
    [Route("/")]
    public string Index()
    {
        return "Hello from Index";
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

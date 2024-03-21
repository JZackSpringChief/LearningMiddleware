
using Microsoft.AspNetCore.Mvc;

namespace refreashOnCsharp.Controllers;

//[Route("[controller]")]
public class HomeController : Controller
{
    [Route("sayhello")]
    public string method1()
    {
        return "Hello from method1";
    }
}

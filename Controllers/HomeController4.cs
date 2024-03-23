using Microsoft.AspNetCore.Mvc;
namespace refreashOnCsharp.Controllers;

public class HomeController4 : Controller
{
    [Route("Home")]
    public IActionResult Index()
    {
        return View();
        //return new PartialViewResult() { ViewName = "abc" }; lengthy way
    }
}

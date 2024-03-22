using refreashOnCsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace refreashOnCsharp.Controllers;
public class HomeController3 : Controller
{
    [Route("register")]
    public IActionResult Index(Person1 person1)
    {
        return Content($"{person1}");
    }


}

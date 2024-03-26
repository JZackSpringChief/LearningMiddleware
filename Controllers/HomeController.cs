using Microsoft.AspNetCore.Mvc;
using Service;
namespace refreashOnCsharp.Controllers;

public class HomeController : Controller
{
    private readonly CitiesService _citiesService;
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}

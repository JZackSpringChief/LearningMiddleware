using Microsoft.AspNetCore.Mvc;
using Service;
using ServiceContracts;
namespace refreashOnCsharp.Controllers;

public class HomeController : Controller
{
    private readonly ICitiesService _citiesService;

    public HomeController(ICitiesService citiesService)
    {
        _citiesService = citiesService;//new CitiesService();
    }

    [Route("/")]
    public IActionResult Index()
    {
        List<string> cities = _citiesService.GetCities();
        return View(cities);
    }
}

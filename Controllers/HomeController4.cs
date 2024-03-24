using Microsoft.AspNetCore.Mvc;
using refreashOnCsharp.Models;
namespace refreashOnCsharp.Controllers;

public class HomeController4 : Controller
{
    [Route("Home")]
    [Route("/")]
    public IActionResult Index()
    {
        ViewData["appTitle"] = "Asp.Net core Demo app";

        List<Person3> people = new()
        {
            new Person3 {Name = "Kylie", DateOfBirth = DateTime.Parse("2005-08-19"), PersonGender = Gender.Female},
            new Person3 {Name = "Zack", DateOfBirth = DateTime.Parse("1989-11-30"), PersonGender = Gender.Male},
            new Person3 {Name = "Blair", DateOfBirth = DateTime.Parse("2025-07-13"), PersonGender = Gender.Male},
        };
        //ViewData["people"] = people;
        // or can do this ViewBag.people = people;
        return View("Index", people);
        //return new PartialViewResult() { ViewName = "abc" }; lengthy way
    }
    [Route("person-details/{name}")]
    public IActionResult Details(string? name)
    {
        if (name == null)

            return Content("Person name can't be null");
        List<Person3> people = new()
        {
            new Person3 {Name = "Kylie", DateOfBirth = DateTime.Parse("2005-08-19"), PersonGender = Gender.Female},
            new Person3 {Name = "Zack", DateOfBirth = DateTime.Parse("1989-11-30"), PersonGender = Gender.Male},
            new Person3 {Name = "Blair", DateOfBirth = DateTime.Parse("2025-07-13"), PersonGender = Gender.Male},
        };
        Person3? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();
        return View(matchingPerson);

    }
}

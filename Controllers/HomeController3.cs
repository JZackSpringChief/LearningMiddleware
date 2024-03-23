using refreashOnCsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace refreashOnCsharp.Controllers;
public class HomeController3 : Controller
{
    [Route("register")]
    //[Bind(nameof(Person1.PersonName), nameof(Person1.Email), nameof(Person1.Password), nameof(Person1.ConfirmPassword))]
    public IActionResult Index(Person1 person1)
    {
        if (!ModelState.IsValid)
        {
            string errors = string.Join("\n",
            ModelState.Values.SelectMany(value => value.Errors).Select
            (err => err.ErrorMessage));

            return BadRequest(errors);
        }
        return Content($"{person1}");
    }


}

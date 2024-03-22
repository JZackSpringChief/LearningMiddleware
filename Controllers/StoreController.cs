
using Microsoft.AspNetCore.Mvc;


namespace refreashOnCsharp.Controllers;

public class StoreController : Controller
{
    [Route("store/books")]
    public IActionResult Books()
    {
        return Content("Kylie Is a Cutie!!!");
    }
}

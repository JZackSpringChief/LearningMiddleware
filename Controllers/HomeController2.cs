
using Microsoft.AspNetCore.Mvc;


namespace refreashOnCsharp.Controllers;

//[Route("[controller]")]
public class HomeController2 : Controller
{
    [Route("bookstore")]
    public IActionResult Index()
    {
        if (!Request.Query.ContainsKey("bookid"))
        {
            return BadRequest("book id is not supplied");
        }
        if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
        {
            return BadRequest("Book id can't be null or empty");

        }
        int bookId = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookid"]);
        if (bookId <= 0)
        {
            return BadRequest("Book id can't be less than 0");
        }
        if (bookId > 1000)
        {

            return NotFound("Book id cannot be greater than 1000");
        }
        if (Convert.ToBoolean(Request.Query["isloggedin"]) == false)
        {
            return Unauthorized("User is not logged in");
        }
        return RedirectToAction("Books", "Store", true);
    }
}

using Microsoft.AspNetCore.Mvc;


namespace refreashOnCsharp.Controllers;

//[Route("[controller]")]
public class HomeController2 : Controller
{
    [Route("book")]
    public IActionResult Index()
    {
        if (!Request.Query.ContainsKey("bookid"))
        {
            Response.StatusCode = 400;
            return Content("book id is not supplied");
        }
        if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
        {
            Response.StatusCode = 400;
            return Content("Book id can't be null or empty");
        }
        int bookId = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookid"]);
        if (bookId <= 0)
        {
            Response.StatusCode = 400;
            return Content("Book id can't be less than 0");
        }
        if (bookId > 1000)
        {

            return Content("Book id cannot be greater than 1000");
        }
        if (Convert.ToBoolean(Request.Query["isloggedin"]) == false)
        {
            Response.StatusCode = 401;
            return Content("User is not logged in");
        }
        return Content("Kylie's a Cutie!!!");
    }
}
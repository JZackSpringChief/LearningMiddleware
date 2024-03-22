
using Microsoft.AspNetCore.Mvc;


namespace refreashOnCsharp.Controllers;

//[Route("[controller]")]
public class HomeController2 : Controller
{
    [Route("bookstore/{bookid?}/{isloggedin?}")]
    public IActionResult Index(int? bookid, bool? isloggedin)
    {
        if (bookid.HasValue == false)
        {
            return BadRequest("book id is not supplied");
        }
        if (bookid == null)
        {
            return BadRequest("Book id can't be null or empty");
        }

        if (bookid <= 0)
        {
            return BadRequest("Book id can't be less than 0");
        }
        if (bookid > 1000)
        {

            return NotFound("Book id cannot be greater than 1000");
        }
        if (isloggedin == false)
        {
            return Unauthorized("User is not logged in");
        }

        return Content($"book Id is {bookid}");
        //return RedirectToActionPermanent("Books", "Store", new
        // {
        // id = bookId
        // });
        // return LocalRedirectResult($"store/books/{bookId}");

    }
}
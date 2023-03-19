using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using static WeddingPlanner.Controllers.UserController;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{

    private MyContext db;  // or use _context instead of db

    public WeddingController(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [SessionCheck]
    [HttpGet("/weddings")]
    public IActionResult All()
    {
        List<Wedding> allWeddings = db.Weddings.ToList();
        return View("All", allWeddings);
    }

     // Name this anything you want with the word "Attribute" at the end
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Find the session, but remember it may be null so we need int?
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            // Check to see if we got back null
            if (userId == null)
            {
                // Redirect to the Index page if there was nothing in session
                // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
                context.Result = new RedirectToActionResult("Index", "User", null);
            }
        }
    }
}
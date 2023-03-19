using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LoginRegistration.Controllers;

public class UserController : Controller
{

    private MyContext db;  // or use _context instead of db

    public UserController(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
    }
    [SessionCheck]
    [HttpGet("success")]
    public IActionResult Success()
    {
        return View("Success");
    }

    [HttpPost("/register")]
    public IActionResult Register(User user)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        PasswordHasher<User> Hasher = new PasswordHasher<User>();
        user.Password = Hasher.HashPassword(user, user.Password);

        db.Users.Add(user);
        db.SaveChanges();
        HttpContext.Session.SetInt32("UserId", user.UserId);
        return RedirectToAction("Success");
    }

    [HttpPost("/login")]
    public IActionResult Login(LogUser logUser)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        User? userInDb = db.Users.FirstOrDefault(u => u.Email == logUser.LogEmail);
        if (userInDb is null)
        {
            ModelState.AddModelError("LogEmail", "Invalid Email/Password");
            return View("Index");
        }
        PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
        var result = hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.LogPassword);
        if (result == 0)
        {
            ModelState.AddModelError("LogEmail", "Invalid Email/Password");
            return View("Index");
        }
        HttpContext.Session.SetInt32("UserId", userInDb.UserId);
        return RedirectToAction("Success");
    }

    [HttpPost("/logout")]
    public IActionResult Logout(){
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
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
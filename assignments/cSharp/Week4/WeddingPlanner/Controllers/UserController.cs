using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WeddingPlanner.Controllers;

public class UserController : Controller
{
    private MyContext db;  // or use _context instead of db

    public UserController(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        if(HttpContext.Session.GetInt32("UserId") is not null){
            return RedirectToAction("All", "Wedding");
        }
        return View("Index");
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
        return RedirectToAction("All", "Wedding");
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
        return RedirectToAction("All", "Wedding");
    }

    [HttpPost("/logout")]
    public IActionResult Logout(){
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
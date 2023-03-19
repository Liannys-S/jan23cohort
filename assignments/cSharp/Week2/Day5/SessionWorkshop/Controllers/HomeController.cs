using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("process")]
    public IActionResult ProcessForm(User user)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        HttpContext.Session.SetString("userName", user.Name);
        return RedirectToAction("Dashboard");
    }
    [HttpGet("dashboard")]
    public IActionResult DashBoard()
    {
        string? name = HttpContext.Session.GetString("userName");
        if (name is null)
        {
            return RedirectToAction("Index");
        }
        return View("Dashboard", name);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

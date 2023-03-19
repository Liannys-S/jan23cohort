using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.Clear();
        return View();
    }
    [HttpPost("/validate")]
    public IActionResult Validate(User user){
        if(!ModelState.IsValid){
            return View("Index");
        }
        HttpContext.Session.SetString("Name", user.FirstName);
        return RedirectToAction("Dashboard");
    }

    [HttpGet("dashboard")]
    public IActionResult Dashboard(){
        string? name =  HttpContext.Session.GetString("Name");
        if(name is null){
            return RedirectToAction("Index");
        }
        return View("Dashboard");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

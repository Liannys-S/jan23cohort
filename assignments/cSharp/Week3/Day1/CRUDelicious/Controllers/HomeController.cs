using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext db;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }

    public IActionResult Index()
    {
        List<Dish> allDishes = db.Dishes.ToList();
        return View("Index", allDishes);
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

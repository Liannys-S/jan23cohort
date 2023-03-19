using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "What's up, Doc?";
        return View("Index",message);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers(){
        int[] nums = new int[]{1,2,3,10,43,5};
        return View(nums); 
    }
    [HttpGet("/users")]
    public IActionResult Users(){
        List<User> listUser = new List<User>(){
            new User("Joslyn"),
            new User("Emily"),
            new User("Liannys"),
        };
        return View(listUser);
    }
    [HttpGet("/user")]
        public IActionResult User(){
            User user = new User("Liannys");
            return View(user);
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

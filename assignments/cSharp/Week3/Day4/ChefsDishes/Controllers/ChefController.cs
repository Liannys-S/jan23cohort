using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Controllers;

public class ChefController : Controller
{

    private MyContext db;  // or use _context instead of db

    public ChefController(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [HttpGet("")]
    public IActionResult Index()
    {   
        List<Chef> allChefs = db.Chefs.Include(c => c.AllDishes).ToList();
        return View("Index", allChefs);  
    }

    [HttpGet("/chefs/new")]
    public IActionResult New(){
        return View("New");
    }

    [HttpPost("chefs/add")]
    public IActionResult Add(Chef newChef){
        if(!ModelState.IsValid){
            return View("New");
        }
        db.Chefs.Add(newChef);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Controllers;

public class DishController : Controller
{

    private MyContext db;  // or use _context instead of db

    public DishController(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [HttpGet("/dishes")]
    public IActionResult All(){
        List<Dish> allDishes = db.Dishes.Include(d => d.dishChef).ToList();
        return View("All", allDishes);
    }
    [HttpGet("/dishes/new")]
    public IActionResult New(){
        ChefAndDish modelList = new ChefAndDish
        {
            Chef = db.Chefs.ToList()
        };
        return View("New", modelList);
    }

    [HttpPost("dishes/add")]
    public IActionResult Add(ChefAndDish modelList){
        if(!ModelState.IsValid){
            modelList.Chef = db.Chefs.ToList();
            return View("New",modelList);
        }
        db.Dishes.Add(modelList.Dish);
        db.SaveChanges();
        Console.WriteLine("Success");
        return RedirectToAction("All");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
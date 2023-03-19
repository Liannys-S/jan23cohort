using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private MyContext db;
    public DishController(MyContext context){
        db = context;
    }

    [HttpGet("/dish/new")]
    public IActionResult New(){
        return View("New");
    }

    [HttpGet("/dishes/{dishId}")]
    public IActionResult Details(int dishId){
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if(dish is null){
            return RedirectToAction("Index","Home");
        }
        return View("Details", dish);
    }

    [HttpGet("/dishes/{dishId}/edit")]
    public IActionResult Edit(int dishId){
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if(dish is null){
            return RedirectToAction("Index","Home");
        }
        return View("Edit", dish);
    }

    [HttpPost("/dish/create")]
    public IActionResult Create(Dish dish){
        if(!ModelState.IsValid){
            return View("New");
        }
        db.Dishes.Add(dish);
        db.SaveChanges();
        Console.WriteLine("done");
        return RedirectToAction("New");
    }

    [HttpPost("/dish/{dishId}/update")]
    public IActionResult Update(Dish editedDish, int dishId){
        if(!ModelState.IsValid){
            // return View("Edit", dishId);
            
            //instead of doing the above you can do this. this reuses the Edit routes functionality, but doesn't create a new request/response cycle, so error messages persist
            //if you use this method, you NEED to make sure that the name of the cshtml file is not defaulted in the "return View()" line of code. write the name in the view 
            return Edit(dishId);
        }

        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if(dish is null){
            return RedirectToAction("Index","Home");
        }

        dish.Chef = editedDish.Chef;
        dish.Name = editedDish.Name;
        dish.Tastiness = editedDish.Tastiness;
        dish.Calories = editedDish.Calories;
        dish.Description = editedDish.Description;
        dish.UpdatedAt = DateTime.Now;
        
        db.Dishes.Update(dish);
        db.SaveChanges();

        return RedirectToAction("Details", new { dishId = dishId});
    }

    [HttpPost("/dish/{dishId}/delete")]
    public IActionResult Delete(int dishId){
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if(dish != null){
            db.Dishes.Remove(dish);
            db.SaveChanges();
        }

        return RedirectToAction("Index","Home");
    }
}

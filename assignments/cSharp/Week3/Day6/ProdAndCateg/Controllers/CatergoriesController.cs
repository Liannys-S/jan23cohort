using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdAndCateg.Models;

namespace ProdAndCateg.Controllers;

public class Categories : Controller
{
    private MyContext db;  // or use _context instead of db

    public Categories(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [HttpGet("/categories")]
    public IActionResult Index()
    {
        MyViewModel myModels = new MyViewModel
        {
            AllCategories = db.Categories.ToList()
        };
        return View("Index", myModels);  
    }

    [HttpPost("categories/new")]
    public IActionResult New(Category category){
        if(!ModelState.IsValid){
            MyViewModel myModels = new MyViewModel
            {
                AllCategories = db.Categories.ToList(),
                Category = category
            };
            return View("Index", myModels);
        }
        db.Categories.Add(category);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet("/categories/{categoryId}")]
    public IActionResult View(int categoryId){
        Category? category = db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        if(category is null){
        return RedirectToAction("Index");
        }
        return View("View",category);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
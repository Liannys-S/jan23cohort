using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdAndCateg.Models;

namespace ProdAndCateg.Controllers;

public class ProductController : Controller
{
    private MyContext db;  // or use _context instead of db

    public ProductController(MyContext context)
    {
        db = context; // if you use _context above use it here too
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        MyViewModel myModels = new MyViewModel
        {
            AllProducts = db.Products.ToList()
        };
        return View("Index", myModels);  
    }

    [HttpPost("products/new")]
    public IActionResult New(Product product){
        if(!ModelState.IsValid){
            MyViewModel myModels = new MyViewModel
            {
                AllProducts = db.Products.ToList(),
                Product = product
            };
            return View("Index", myModels);
        }
        db.Products.Add(product);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet("/products/{productId}")]
    public IActionResult View(int productId){
        Product? product = db.Products.FirstOrDefault(p => p.ProductId == productId);
        if(product is null){
            return RedirectToAction("Index");
        }
        return View("View",product);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
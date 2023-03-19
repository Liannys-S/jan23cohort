#pragma warning disable CS8618

namespace ProdAndCateg.Models;

public class MyViewModel{
    public List<Product> AllProducts { get; set; } = new List<Product>();
    public Product Product { get; set; }
    public List<Category> AllCategories { get; set; } = new List<Category>();
    public Category Category { get; set; }


}
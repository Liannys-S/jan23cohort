#pragma warning disable CS8618
namespace ChefsDishes.Models;

public class ChefAndDish
{
    public List<Chef> Chef {get;set;} = new List<Chef>();
    public Dish Dish {get;set;}

}
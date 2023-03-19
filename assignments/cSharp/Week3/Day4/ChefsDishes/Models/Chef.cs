#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsDishes.Models;

public class Chef {
    [Key]
    public int ChefId {get; set;}
    [Required]
    [Display(Name ="First Name")]
    public string FirstName {get;set;}
    [Required]
    [Display(Name ="Last Name")]
    public string LastName {get;set;}
    [Display(Name ="Date of Birth")]
    [Required]
    [FutureDate]
    [DataType(DataType.Date)]
    [OverEighteen]
    public DateTime Birthday {get;set;}    
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Dish> AllDishes {get;set;} = new List<Dish>();
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if(((DateTime)value) >= DateTime.Now.Date){
            return new ValidationResult("Date entered must before today's date");
        }else{
            return ValidationResult.Success;
        }
        // You first may want to unbox "value" here and cast to to a DateTime variable!
    }
}
public class OverEighteenAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        int year = DateTime.Now.Year - ((DateTime)value).Year;
        if((((DateTime)value).Month > DateTime.Now.Month) || (((DateTime)value).Month == DateTime.Now.Month && ((DateTime)value).Day > DateTime.Now.Day)){
            year--;
        }
        if(year < 18){
            return new ValidationResult("Must be older than 18");
        }else{
            return ValidationResult.Success;
        }
        // You first may want to unbox "value" here and cast to to a DateTime variable!
    }
}

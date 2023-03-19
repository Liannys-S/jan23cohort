#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

public class Wedding{
    [Key]
    public int WeddingId { get; set; }
    [Display(Name ="Wedder One")]
    [Required]
    public string WedderOne { get; set; }
    [Display(Name ="Wedder Two")]
    [Required]
    public string WedderTwo { get; set; }

    [Required]
    [FutureDate]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public List<Reservation> Guests { get; set; } = new List<Reservation>();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if(((DateTime)value) <= DateTime.Now.Date){
            return new ValidationResult("Date entered must be after today's date");
        }else{
            return ValidationResult.Success;
        }
        // You first may want to unbox "value" here and cast to to a DateTime variable!
    }
}
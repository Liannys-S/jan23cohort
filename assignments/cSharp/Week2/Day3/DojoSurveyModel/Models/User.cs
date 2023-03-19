#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models;
public class User
{
    [Required]
    [MinLength(2,ErrorMessage ="Name must be at least 2 characters long")]
    public string Name{ get; set; }
    [Required]
    public string Location{ get; set; }
    [Required]
    public string Language{ get; set; }
    [MinLength(20, ErrorMessage ="Comment must be at least 20 characters")]
    public string? Comment{ get; set; }

    [DataType(DataType.Date)]
    [FutureDate]
    public DateTime Birthday{get; set; }
    
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


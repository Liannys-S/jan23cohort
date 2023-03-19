#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;

public class User{
    [Required]
    [MinLength(4,ErrorMessage ="must be at least 4 characters long")]
    public string FirstName {get;set;}

    [Required]
    [MinLength(4,ErrorMessage ="must be at least 4 characters long")]
    public string LastName {get;set;}
    
    [Required]
    [Range(0,Int32.MaxValue, ErrorMessage = "must be a positive number")]
    public int Age {get;set;}

    [Required]
    [EmailAddress(ErrorMessage ="enter a valid email")]
    public string Email {get;set;}

    [Required]
    [DataType(DataType.Password)]
    public string Password {get;set;}
}
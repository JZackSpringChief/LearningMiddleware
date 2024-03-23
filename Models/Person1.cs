
using System.ComponentModel.DataAnnotations;
using refreashOnCsharp.CustomValidators;

namespace refreashOnCsharp.Models;

public class Person1
{
    [Required(ErrorMessage = "{0} Cant be null or empty")]
    [Display(Name = "Person Name")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} characters long")]
    [RegularExpression("^[A-Za-z .]$", ErrorMessage = "{0} should contain only alphabets, space and dot (.)")]
    public string? PersonName { get; set; }
    [Required(ErrorMessage = "{0} cannot be blank")]
    [EmailAddress(ErrorMessage = "{0} should be a proper email address")]
    public string? Email { get; set; }
    [Phone(ErrorMessage = "{0} should contain 10 digits")]
    //[ValidateNever]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "{0} Cannot be blank")]
    public string? Password { get; set; }
    [Required(ErrorMessage = "")]
    [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
    [Display(Name = "Re-enter Password")]
    public string? ConfirmPassword { get; set; }
    [Required]
    [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
    public string? Price { get; set; }
    [MinimunYearValidator(2005, ErrorMessage = "Year cannot be greater than or equal to {0}")]
    public DateTime? DateOfBirth { get; set; }

    public DateTime? FromDate { get; set; }
    [DateRangeValidator("FromDate", ErrorMessage = "'From Date' should be older than or equal to 'to date")]
    public DateTime? ToDate { get; set; }
    public override string ToString()
    {
        return $"Person Object - - - Person Name: {PersonName}, Email: {Email}, Phone: {Phone}, Password: {Password}, Confirm Password: {ConfirmPassword}, Price: {Price} ";
    }
}
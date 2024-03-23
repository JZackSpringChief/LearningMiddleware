
using System.ComponentModel.DataAnnotations;

namespace refreashOnCsharp.Models;

public class Person1
{
    [Required(ErrorMessage = "{0} Cant be null or empty")]
    [Display(Name = "Person Name")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} sould be between {2} and {1} characters long")]
    public string? PersonName { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Phone { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? ConfirmPassword { get; set; }
    [Required]
    [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
    public string? Price { get; set; }

    public override string ToString()
    {
        return $"Person Object - - - Person Name: {PersonName}, Email: {Email}, Phone: {Phone}, Password: {Password}, Confirm Password: {ConfirmPassword}, Price: {Price} ";
    }
}
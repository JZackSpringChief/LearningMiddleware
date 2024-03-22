
using System.ComponentModel.DataAnnotations;

namespace refreashOnCsharp.Models;

public class Person1
{
    [Required]
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
    public string? Price { get; set; }

    public override string ToString()
    {
        return $"Person Object - - - Person Name: {PersonName}, Email: {Email}, Phone: {Phone}, Password: {Password}, Confirm Password: {ConfirmPassword}, Price: {Price} ";
    }
}
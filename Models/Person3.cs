

namespace refreashOnCsharp.Models;

public class Person3
{
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Gender PersonGender { get; set; }
}
public enum Gender
{
    Male, Female
}

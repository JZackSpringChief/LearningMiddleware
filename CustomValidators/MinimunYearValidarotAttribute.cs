

// using System.ComponentModel.DataAnnotations;

// namespace refreashOnCsharp.CustomValidators;

// public class MinimunYearValidatorAttribute : ValidationAttribute
// {
//     public int MinimumYear { get; set; } = 2000;
//     public string DefaultErrorMsg { get; set; } = "Year should not be less than {0}";
//     public MinimunYearValidatorAttribute()
//     {

//     }
//     public MinimunYearValidatorAttribute(int minumumYear)
//     {
//         MinimumYear = minumumYear;
//     }
//     protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
//     {
//         if (value != null)
//         {
//             DateTime date = (DateTime)value;
//             if (date.Year >= MinimumYear)
//             {
//                 return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMsg, MinimumYear));
//             }
//             else
//             {
//                 return ValidationResult.Success;
//             }
//         }
//         return null;
//     }
// }

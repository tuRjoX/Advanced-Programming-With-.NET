using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_LAB_3.Models
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
   _minimumAge = minimumAge;
      ErrorMessage = $"You must be at least {_minimumAge} years old.";
     }

     protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
           return ValidationResult.Success;
      }

            if (value is DateTime dateOfBirth)
    {
    var today = DateTime.Today;
   var age = today.Year - dateOfBirth.Year;
    
 if (dateOfBirth.Date > today.AddYears(-age))
       {
  age--;
     }

       if (age >= _minimumAge)
                {
          return ValidationResult.Success;
        }

 return new ValidationResult(ErrorMessage);
       }

         return new ValidationResult("Invalid date format.");
        }
    }
}

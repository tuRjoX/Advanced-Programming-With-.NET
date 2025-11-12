using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_LAB_3.Models
{
    public class MatchingIdEmailAttribute : ValidationAttribute
    {
   protected override ValidationResult IsValid(object value, ValidationContext validationContext)
     {
       var student = (Student)validationContext.ObjectInstance;

            if (string.IsNullOrEmpty(student.Id) || string.IsNullOrEmpty(student.Email))
 {
   return ValidationResult.Success;
      }
            var emailPrefix = student.Email.Split('@')[0];

            if (student.Id != emailPrefix)
        {
       return new ValidationResult("ID and Email prefix (XX-XXXXX-XX) must match.");
  }

            return ValidationResult.Success;
        }
    }
}

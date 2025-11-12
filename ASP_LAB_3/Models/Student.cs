using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_LAB_3.Models
{
    [MatchingIdEmail(ErrorMessage = "ID and Email prefix (XX-XXXXX-XX) must match.")]
    public class Student
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s.\-]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string Name { get; set; }
        
        [Required]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "Space Not Allowed")]
        public string Username { get; set; }
   
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "Pattern Must Be XX-XXXXX-X and must be number")]
        public string Id { get; set; }
        
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [MinimumAge(18)]
        public DateTime DOB { get; set; }
 
        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[0-9]{1}@student\.aiub\.edu$", ErrorMessage = "Email must be like XX-XXXXX-X@student.aiub.edu")]
        public string Email { get; set; }
    }
}
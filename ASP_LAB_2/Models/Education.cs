using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01.Models
{
    public class Education
    {
        public string degree { get; set; }
        public string institution { get; set; }
        public string yearOfCompletion { get; set; }
        public Education(string degree, string institution, string yearOfCompletion)
        {
            this.degree = degree;
            this.institution = institution;
            this.yearOfCompletion = yearOfCompletion;
        }
    }
}
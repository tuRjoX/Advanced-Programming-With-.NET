using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01.Models
{
    public class Contact
    {
        public string name { get; set; }
        public string email { get; set; }
        public string gitLink { get; set; }

        public Contact(string name, string email, string gitLink)
        {
            this.name = name;
            this.email = email;
            this.gitLink = gitLink;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01.Models
{
    public class Project
    {
        public string title { get; set; }
        public string description { get; set; }
        public string gitLink { get; set; }

        public Project(string title, string description, string gitLink)
        {
            this.title = title;
            this.description = description;
            this.gitLink = gitLink;
        }
    }
}
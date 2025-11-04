using Lab01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Lab01.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Education()
        {
            Education[] educations = new Education[]
            {
                new Education( degree: "Bachelor of Science in Computer Science", institution: "American International University-Bangladesh", yearOfCompletion: "2026"),
                new Education( degree: "Higher Secondary Certificate", institution: "Govt. Syed Hatemali College", yearOfCompletion: "2021"),
                new Education( degree: "Secondary School Certificate", institution: "Barisal Zilla School", yearOfCompletion: "2019"),
            };
            return View(educations);
        }
        public ActionResult Contact()
        {
            Contact contact = new Contact(name: "Turjo Das Dip", email: "tdas41380@gmail.com", gitLink: "https://github.com/tuRjoX");
            return View(contact);
        }
        public ActionResult Projects()
        {
            Project[] projects = new Project[]
            {
                new Project( title: "Savore Resturant Management System", description: "A Resturant Management System", gitLink: "https://github.com/tuRjoX/savore-restaurant.git"),
                new Project ( title: "LifeLine Blood Bank Management System", description: "A Blood Donation Platform", gitLink: "https://github.com/tuRjoX/LifeLine-Blood-Bank.git"),
                new Project ( title: "Tripify: Travel & Tourism Management System", description: "A hotel & resort booking system", gitLink: "https://github.com/tuRjoX/Tripify-A-Travel-and-Tourisam-Management-Solution.git"),

            };

            return View(projects);
        }
        
    }
}
using ASP_LAB_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_LAB_3.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View("Registration");
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Registration(Student s) { 
            if(ModelState.IsValid)
            {
                TempData["Msg"] = "Registration Successful";
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }
}
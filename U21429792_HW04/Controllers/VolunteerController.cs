using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U21429792_HW04.ViewModels;
using System.Data;

namespace U21429792_HW04.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VolunteerPage()
        {
            List<VolunteerViewModel> volunteers = GetData(VolunteerViewModel model);
            return View(volunteers);
        }
        public ActionResult DonatePage()
        {
            ViewBag.Message = "Your donate page.";

            return View();
        }

        public ActionResult ContactPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Narratives()
        {
            ViewBag.Message = "Your narratives page.";

            return View();
        }

        private List<VolunteerViewModel> GetData(VolunteerViewModel model)
        {
            List<VolunteerViewModel> volunteers = new List<VolunteerViewModel>();
            VolunteerViewModel volunteer1 = new VolunteerViewModel("John", "Doe", "Afghanistan", "5");
            VolunteerViewModel volunteer2 = new VolunteerViewModel("Jane", "Doe", "Hungary", "6");
            VolunteerViewModel volunteer3 = new VolunteerViewModel("Peter", "Piper", "North Korea", "3");
            VolunteerViewModel volunteer4 = new VolunteerViewModel($"{model.Name}", $"{model.Surname}", $"{model.Area}", $"{model.Days}");
            volunteers.Add(volunteer1);
            volunteers.Add(volunteer2);
            volunteers.Add(volunteer3);
            volunteers.Add(volunteer4);
            return volunteers;
        }
    }
}
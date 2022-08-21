using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using U21429792_HW04.ViewModels;

namespace U21429792_HW04.Controllers
{
    public class DonatorController : Controller
    {
        // GET: Donator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VolunteerPage()
        {
            ViewBag.Message = "Your volunteer page.";

            return View();
        }
        public ActionResult DonatePage()
        {
            List<DonatorViewModel> donators = GetData();
            return View(donators);
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
        private List<DonatorViewModel> GetData()
        {
            List<DonatorViewModel> donators = new List<DonatorViewModel>();
            DonatorViewModel donator1 = new DonatorViewModel("John", "Doe", "Nepal", "5000");
            DonatorViewModel donator2 = new DonatorViewModel("Jane", "Doe", "Afghanistan", "6000");
            DonatorViewModel donator3 = new DonatorViewModel("Peter", "Piper", "Philippines", "3000");
            DonatorViewModel donator4 = new DonatorViewModel($"Name", $"Surname", $"Area", $"Amount");
            donators.Add(donator1);
            donators.Add(donator2);
            donators.Add(donator3);
            donators.Add(donator4);
            return donators;
        }
    }
}
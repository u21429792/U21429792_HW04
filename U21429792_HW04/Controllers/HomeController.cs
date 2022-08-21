using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace U21429792_HW04.Controllers
{
    public class HomeController : Controller
    {
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TermsConditions()
        {
            return View();
        }

        public ActionResult SmartHome()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Solutions()
        {
            return View();
        }

        public ActionResult Estimate()
        {
            return View();
        }
    }
}
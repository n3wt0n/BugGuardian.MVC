using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugGuardian.MVC.TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = int.Parse("error");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
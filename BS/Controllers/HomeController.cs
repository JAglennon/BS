using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Logo
            ViewBag.Title = "Barry and Sian";
           // ViewBag.Logo = "~/images/Barry Sian Nutshell.ico";
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetMeWeb.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()

        {
            return View();
        }

        public PartialViewResult Partial1()

        { 
         return PartialView();
        }
    }
}
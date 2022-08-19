using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetMeWeb.Models.Siniflar;

namespace PetMeWeb.Controllers
{
    public class BilgilerController : Controller
    {
        // GET: Bilgiler
        Context l = new Context();
        public ActionResult Bilgiler()
        {
            var yarbilgiler = l.Bilgilers.ToList();
            return View(yarbilgiler);
        }
    }
}

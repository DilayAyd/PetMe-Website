using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetMeWeb.Models.Siniflar;

namespace PetMeWeb.Controllers
{
    public class BuldumController : Controller
    {
        // GET: Buldum
        Context u = new Context();
        public ActionResult KayipBuldum()
        {
            var buldumlar = u.KayipBuldumCs.ToList();
            return View(buldumlar);
        }
    }
}
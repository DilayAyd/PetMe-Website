using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetMeWeb.Models.Siniflar;

namespace PetMeWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        [Authorize]

        public ActionResult Index()
        {
            var degerler = c.DostumKayips.ToList();
            return View(degerler);
        }

        [HttpGet]
        //sayfa yüklenir yüklenmez verileri kaydetmemek için 

        public ActionResult YeniKayip()

        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniKayip(DostumKayip p)

        {
            return View();

        }
    }
}
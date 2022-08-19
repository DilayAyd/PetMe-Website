using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetMeWeb.Models.Siniflar;

namespace PetMeWeb.Controllers
{
    public class KayipController : Controller
    {
        // GET: Kayip
        Context c = new Context();

        public ActionResult DostumKayip()
        {
            var kayiplar = c.DostumKayips.ToList();
            return View(kayiplar);
        }

        KayipYorum ky = new KayipYorum();

        public ActionResult KayipDetay(int id)
        {
            //var kayipbul = c.DostumKayips.Where(x => x.ID == id).ToList();
            ky.Deger1= c.DostumKayips.Where(x => x.ID == id).ToList();
            ky.Deger2 = c.Yorumlars.Where(y => y.Kayipid == id).ToList();
            return View(ky);
        }
         
    }
}
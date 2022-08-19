using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetMeWeb.Models.Siniflar;

namespace PetMeWeb.Controllers
{
    public class SahiplendirmeController : Controller
    {
        // GET: Sahiplendirme

        Context b = new Context();
        public ActionResult Sahiplendirme()
        {
            var sahipler = b.Sahiplendirmes.ToList();
            return View(sahipler);
        }

        SahipYorum sy = new SahipYorum();

        public ActionResult SahipDetay(int idm)
        {
            //var kayipbul = c.DostumKayips.Where(x => x.ID == id).ToList();
            sy.Deger3 = b.Sahiplendirmes.Where(z => z.ID2 == idm).ToList();
            sy.Deger4 = b.SahipYorumlars.Where(t => t.sahipid == idm).ToList();
            return View(sy);
        }
    }
}
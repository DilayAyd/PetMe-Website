using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetMeWeb.Models.Siniflar
{
    public class KayipYorum
    {
        public IEnumerable<DostumKayip> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
    }
}
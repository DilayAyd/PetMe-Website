using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetMeWeb.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Kayipid { get; set; }
        public virtual DostumKayip DostumKayip { get; set; }
        // yorum  eklerken ilan da eklememek için 

    }
}
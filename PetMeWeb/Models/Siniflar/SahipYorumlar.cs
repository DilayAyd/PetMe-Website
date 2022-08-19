using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetMeWeb.Models.Siniflar
{
    public class SahipYorumlar
    {
        [Key]
        public int ID2 { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int sahipid { get; set; }
        public virtual Sahiplendirme Sahiplendirme { get; set; }
    }
}
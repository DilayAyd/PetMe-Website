using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PetMeWeb.Models.Siniflar
{
    public class Sahiplendirme
    {

        [Key]
        public int ID2 { get; set; }
        public string Baslik { get; set; }
        public string Tür { get; set; }
        public string İsim { get; set; }
        public string Yas { get; set; }
        public string Renk { get; set; }
        public string İl { get; set; }
        public string Tarih { get; set; }
        public string Aciklama { get; set; }
        public string SahipImage { get; set; }
        public ICollection<SahipYorumlar> SahipYorumlars { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetMeWeb.Models.Siniflar
{
    public class KayipBuldumC
    {

        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Tür { get; set; }
      
        public string Renk { get; set; }
        public string İl { get; set; }
        public string Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BuldumImage { get; set; }
        //public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}
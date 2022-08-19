using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetMeWeb.Models.Siniflar
{
    public class Bilgiler
    {

        [Key]
        public int ID4 { get; set; }
        public string KapakFoto { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }
        public string Foto3 { get; set; }
        public string Foto4 { get; set; }
        public string Baslik { get; set; }
        public string Baslik2 { get; set; }
        public string Baslik3 { get; set; }
        public string Baslik4 { get; set; }
        public string Baslik5 { get; set; }
        public string Baslik6 { get; set; }
        public string Metin { get; set; }
        public string Metin2 { get; set; }
        public string Metin3 { get; set; }
        public string Metin4 { get; set; }
        public string Metin5 { get; set; }
        public string Metin6 { get; set; }
       
    }
}
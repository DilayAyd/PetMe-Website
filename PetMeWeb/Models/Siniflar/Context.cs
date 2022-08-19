using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetMeWeb.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet <KayipBuldumC> KayipBuldumCs { get; set; }
        public DbSet <Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<DostumKayip> DostumKayips { get; set; }
        public DbSet<Sahiplendirme> Sahiplendirmes { get; set; }
        public DbSet<SahipYorumlar> SahipYorumlars { get; set; }
        public DbSet<Bilgiler> Bilgilers { get; set; }
    }
}  
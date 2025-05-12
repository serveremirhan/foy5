using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using foy5.Models;

namespace foy5.Data
{
    internal class OgrenciContext : DbContext 
    {
        public OgrenciContext() : base("name=OgrenciDB") { }

        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersleri { get; set; }
        public object Dersler { get; internal set; }
    }
}

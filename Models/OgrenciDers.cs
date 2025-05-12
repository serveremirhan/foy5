using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foy5.Models
{
    internal class OgrenciDers
    {
        [Key]
        public int ID { get; set; } // Composite key yerine basit bir ID

        [ForeignKey("Ogrenci")]
        public int OgrenciID { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }

        public int DersID { get; set; } // Ders tablosu istenmediği için sadece ID tutuyoruz
        public int Yil { get; set; }
        public int Yariyil { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
    }
}

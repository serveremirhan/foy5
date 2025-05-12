using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foy5.Models
{
    internal class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }

        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }

        [ForeignKey("Bolum")]
        public int BolumID { get; set; }
        public virtual Bolum Bolum { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDersleri { get; set; }
        public object Fakulte { get; internal set; }
    }
}

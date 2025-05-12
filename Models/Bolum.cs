using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foy5.Models
{
    internal class Bolum
    {
        [Key]
        public int BolumID { get; set; }
        [Required]
        public string BolumAd { get; set; }

        [ForeignKey("Fakulte")]
        public int FakulteID { get; set; }
        public virtual Fakulte Fakulte { get; set; }

        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}

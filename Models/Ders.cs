using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foy5.Models
{
    internal class Ders
    {
        [Key]
        public int DersID { get; set; }
        [Required]
        public string DersAd { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDersleri { get; set; }
    }
}

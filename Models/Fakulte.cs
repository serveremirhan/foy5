using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace foy5.Models
{
    internal class Fakulte
    {
        [Key]
        public int FakulteID { get; set; }
        [Required]
        public string FakulteAd { get; set; }

        public virtual ICollection<Bolum> Bolumler { get; set; }
    }
}

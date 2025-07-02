using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace foy5form_but.Models
{
    public class tDers
    {
        [Key]
        public int dersID { get; set; }
        public string dersAd { get; set; }

        public virtual ICollection<tOgrenciDers> OgrenciDersleri { get; set; }
    }
}
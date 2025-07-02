using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foy5form_but.Models
{
    public class tBolum
    {
        [Key]
        public int bolumID { get; set; }
        public string bolumAd { get; set; }

        public int fakulteID { get; set; }
        [ForeignKey("fakulteID")]
        public virtual tFakulte Fakulte { get; set; }

        public virtual ICollection<tOgrenci> Ogrenciler { get; set; }
    }
}

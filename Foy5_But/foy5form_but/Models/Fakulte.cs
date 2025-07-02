using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace foy5form_but.Models
{
    public class tFakulte
    {
        [Key]
        public int fakulteID { get; set; }
        public string fakulteAd { get; set; }

        public virtual ICollection<tBolum> Bolumler { get; set; }
    }
}

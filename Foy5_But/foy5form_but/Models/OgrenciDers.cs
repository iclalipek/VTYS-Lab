using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foy5form_but.Models
{
    public class tOgrenciDers
    {
        [Key, Column(Order = 0)]
        public int ogrenciID { get; set; }

        [Key, Column(Order = 1)]
        public int dersID { get; set; }

        public int yil { get; set; }
        public string yariyil { get; set; } // "Güz" veya "Bahar"
        public int? vize { get; set; }
        public int? final { get; set; }

        [ForeignKey("ogrenciID")]
        public virtual tOgrenci Ogrenci { get; set; }

        [ForeignKey("dersID")]
        public virtual tDers Ders { get; set; }
    }
}
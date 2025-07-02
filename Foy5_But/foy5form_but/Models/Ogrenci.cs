using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foy5form_but.Models
{
    public class tOgrenci
    {
        [Key] // Öğrenci ID'sinin Primary Key olduğunu belirtir.
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // ID'nin manuel girileceğini belirtir.
        public int ogrenciID { get; set; } // Öğrenci Numarası olarak kullanılacak.
        public string ad { get; set; }
        public string soyad { get; set; }
        public int bolumID { get; set; }

        [ForeignKey("bolumID")]
        public virtual tBolum Bolum { get; set; }
        public virtual ICollection<tOgrenciDers> OgrenciDersleri { get; set; }
    }
}
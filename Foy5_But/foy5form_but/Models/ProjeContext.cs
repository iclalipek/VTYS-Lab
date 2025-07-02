using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace foy5form_but.Models
{
    public class ProjeContext : DbContext
    {
        public ProjeContext() : base("name=ProjeContext")
        {
        }

        public DbSet<tOgrenci> Ogrenciler { get; set; }
        public DbSet<tBolum> Bolumler { get; set; }
        public DbSet<tFakulte> Fakulteler { get; set; }
        public DbSet<tDers> Dersler { get; set; }
        public DbSet<tOgrenciDers> OgrenciDersleri { get; set; }
    }
}
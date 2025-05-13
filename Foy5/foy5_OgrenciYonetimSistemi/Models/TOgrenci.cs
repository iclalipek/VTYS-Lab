using System;
using System.Collections.Generic;

namespace foy5_OgrenciYonetimSistemi.Models;

public partial class TOgrenci
{
    public int OgrenciId { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public int BolumId { get; set; }

    public virtual TBolum Bolum { get; set; } = null!;

    public virtual ICollection<TOgrenciDer> TOgrenciDers { get; set; } = new List<TOgrenciDer>();
}

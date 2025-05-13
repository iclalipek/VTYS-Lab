using System;
using System.Collections.Generic;

namespace foy5_OgrenciYonetimSistemi.Models;

public partial class TDer
{
    public int DersId { get; set; }

    public string DersAd { get; set; } = null!;

    public virtual ICollection<TOgrenciDer> TOgrenciDers { get; set; } = new List<TOgrenciDer>();
}

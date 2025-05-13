using System;
using System.Collections.Generic;

namespace foy5_OgrenciYonetimSistemi.Models;

public partial class TBolum
{
    public int BolumId { get; set; }

    public string BolumAd { get; set; } = null!;

    public int FakulteId { get; set; }

    public virtual TFakulte Fakulte { get; set; } = null!;

    public virtual ICollection<TOgrenci> TOgrencis { get; set; } = new List<TOgrenci>();
}

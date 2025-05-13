using System;
using System.Collections.Generic;

namespace foy5_OgrenciYonetimSistemi.Models;

public partial class TFakulte
{
    public int FakulteId { get; set; }

    public string FakulteAd { get; set; } = null!;

    public virtual ICollection<TBolum> TBolums { get; set; } = new List<TBolum>();
}

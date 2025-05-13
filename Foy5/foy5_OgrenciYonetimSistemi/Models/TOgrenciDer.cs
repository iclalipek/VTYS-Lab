using System;
using System.Collections.Generic;

namespace foy5_OgrenciYonetimSistemi.Models;

public partial class TOgrenciDer
{
    public int OgrenciId { get; set; }

    public int DersId { get; set; }

    public int Yil { get; set; }

    public int Yariyil { get; set; }

    public double? Vize { get; set; }

    public double? Final { get; set; }

    public virtual TDer Ders { get; set; } = null!;

    public virtual TOgrenci Ogrenci { get; set; } = null!;
}

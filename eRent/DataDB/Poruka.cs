using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class Poruka
{
    public int PorukaId { get; set; }

    public int PosiljalacPorukeId { get; set; }

    public int PrimaalacPorukeId { get; set; }

    public string TextPoruke { get; set; } = null!;

    public DateTime DatumPoruke { get; set; }

    public virtual Korisnik PosiljalacPoruke { get; set; } = null!;

    public virtual Korisnik PrimaalacPoruke { get; set; } = null!;
}

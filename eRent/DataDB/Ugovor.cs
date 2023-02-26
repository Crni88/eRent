using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class Ugovor
{
    public int UgovorId { get; set; }

    public int PodnosiocUgovoraId { get; set; }

    public int UgovornaStrankaId { get; set; }

    public int NekretninaId { get; set; }

    public DateTime? DatumSklapanjaUgovora { get; set; }

    public DateTime? VremenskoTrajanjeUgovora { get; set; }

    public virtual Nekretnina Nekretnina { get; set; } = null!;

    public virtual Korisnik PodnosiocUgovora { get; set; } = null!;

    public virtual Korisnik UgovornaStranka { get; set; } = null!;
}

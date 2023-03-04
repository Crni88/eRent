using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Ugovor
{
    public int UgovorId { get; set; }

    public int PodnosiocUgovoraId { get; set; }

    public int NekretninaId { get; set; }

    public DateTime? DatumSklapanjaUgovora { get; set; }

    public DateTime? DatumIstekaUgovora { get; set; }

    public string? PodnosiocUgovora { get; set; }

    public string? UgovornaStranka { get; set; }

    public string? Nekretnina { get; set; }

    public virtual Nekretnina NekretninaNavigation { get; set; } = null!;

    public virtual Korisnik PodnosiocUgovoraNavigation { get; set; } = null!;
}

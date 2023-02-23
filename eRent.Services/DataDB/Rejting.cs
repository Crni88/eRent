using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Rejting
{
    public int RejtingId { get; set; }

    public int KorisnikPrim { get; set; }

    public int KorisnikSec { get; set; }

    public string? Komentar { get; set; }

    public int NekretninaRejting { get; set; }

    public string Nekretnina { get; set; } = null!;

    public string? ImePrezime { get; set; }

    public double Rejting1 { get; set; }

    //public double? OverallRejting { get; set; }

    public virtual Korisnik KorisnikPrimNavigation { get; set; } = null!;

    public virtual Korisnik KorisnikSecNavigation { get; set; } = null!;

    public virtual Nekretnina NekretninaRejtingNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class NekretninaRezervacija
{
    public int NekretninaRezervacija1 { get; set; }

    public int? RezervacijaId { get; set; }

    public int? NekretninaId { get; set; }

    public virtual Nekretnina? Nekretnina { get; set; }

    public virtual Rezervacija? Rezervacija { get; set; }
}

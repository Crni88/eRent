using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Rezervacija
{
    public int RezervacijaId { get; set; }

    public bool? MjesecnaRezervacija { get; set; }

    public DateTime? DatumPocetka { get; set; }

    public DateTime? DatumKraja { get; set; }

    public virtual ICollection<KorisnikRezervacija> KorisnikRezervacijas { get; } = new List<KorisnikRezervacija>();

    public virtual ICollection<NekretninaRezervacija> NekretninaRezervacijas { get; } = new List<NekretninaRezervacija>();
}

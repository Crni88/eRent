using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class NekretninaKorisnik
{
    public int NekretninaKorisnikId { get; set; }

    public int Nekretnina { get; set; }

    public string ImeKorisnika { get; set; } = null!;

    public string PrezimeKorisnika { get; set; } = null!;

    public string BrojTelefona { get; set; } = null!;

    public DateTime? DatumUseljenja { get; set; }

    public DateTime? DatumIseljenja { get; set; }

    public string? Slika { get; set; }

    public virtual Nekretnina NekretninaNavigation { get; set; } = null!;
}

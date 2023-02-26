using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Posjetum
{
    public int PosjetaId { get; set; }

    public int? KorisnikId { get; set; }

    public int? NekretninaId { get; set; }

    public DateTime? DatumPosjete { get; set; }

    public TimeSpan? VrijemePosjete { get; set; }

    public virtual Korisnik? Korisnik { get; set; }

    public virtual Nekretnina? Nekretnina { get; set; }
}

using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class KorisnikRezervacija
{
    public int KorisnikRezervacijaId { get; set; }

    public int? KorisnikId { get; set; }

    public int? RezervacijaId { get; set; }

    public virtual Korisnik? Korisnik { get; set; }

    public virtual Rezervacija? Rezervacija { get; set; }
}

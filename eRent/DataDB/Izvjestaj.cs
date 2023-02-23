using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class Izvjestaj
{
    public int IzvjestajId { get; set; }

    public int? VrstaIzvjestajaId { get; set; }

    public int? KorisnikId { get; set; }

    public DateTime? DatumIzdavanja { get; set; }

    public virtual Korisnik? Korisnik { get; set; }

    public virtual VrstaIzvjestaja? VrstaIzvjestaja { get; set; }
}

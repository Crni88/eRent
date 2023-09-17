using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class FitPaso
{
    public int PasosId { get; set; }

    public int KorisnikId { get; set; }

    public DateTime DatumIzdavanja { get; set; }

    public DateTime DatumIsteka { get; set; }

    public bool IsValid { get; set; }

    public virtual Korisnik Korisnik { get; set; } = null!;
}

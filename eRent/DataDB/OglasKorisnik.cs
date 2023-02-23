using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class OglasKorisnik
{
    public int OglasKorisnikId { get; set; }

    public int KorisnikOglasId { get; set; }

    public int OglasKorisnikId1 { get; set; }

    public virtual Korisnik KorisnikOglas { get; set; } = null!;

    public virtual Ogla OglasKorisnikId1Navigation { get; set; } = null!;
}

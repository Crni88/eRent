using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class KorisnikTagovi
{
    public int KtId { get; set; }

    public int KorisnikId { get; set; }

    public int TagId { get; set; }

    public virtual Korisnik Korisnik { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}

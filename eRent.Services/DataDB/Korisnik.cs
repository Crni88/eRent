using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Korisnik
{
    public int KorisnikId { get; set; }

    public string KorsnikIme { get; set; } = null!;

    public string KorisnikPrezime { get; set; } = null!;

    public string LozinkaHash { get; set; } = null!;

    public string LozinkaSalt { get; set; } = null!;

    public string? Email { get; set; }

    public int? UlogaId { get; set; }

    public double? Rejting { get; set; }

    public string? Username { get; set; }

    public int? BrojOcjena { get; set; }

    public string? FcmDeviceToken { get; set; }

    public virtual ICollection<KorisnikTagovi> KorisnikTagovis { get; } = new List<KorisnikTagovi>();

    public virtual ICollection<Nekretnina> Nekretninas { get; } = new List<Nekretnina>();

    public virtual ICollection<PaymentRequest> PaymentRequests { get; } = new List<PaymentRequest>();

    public virtual ICollection<Posjetum> Posjeta { get; } = new List<Posjetum>();

    public virtual ICollection<Rejting> RejtingKorisnikPrimNavigations { get; } = new List<Rejting>();

    public virtual ICollection<Rejting> RejtingKorisnikSecNavigations { get; } = new List<Rejting>();

    public virtual ICollection<Ugovor> Ugovors { get; } = new List<Ugovor>();

    public virtual Uloga? Uloga { get; set; }
}

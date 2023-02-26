using System;
using System.Collections.Generic;

namespace eRent.DataDB;

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

    public virtual ICollection<Izvjestaj> Izvjestajs { get; } = new List<Izvjestaj>();

    public virtual ICollection<KorisnikRezervacija> KorisnikRezervacijas { get; } = new List<KorisnikRezervacija>();

    public virtual ICollection<Nekretnina> Nekretninas { get; } = new List<Nekretnina>();

    public virtual ICollection<OglasKorisnik> OglasKorisniks { get; } = new List<OglasKorisnik>();

    public virtual ICollection<Poruka> PorukaPosiljalacPorukes { get; } = new List<Poruka>();

    public virtual ICollection<Poruka> PorukaPrimaalacPorukes { get; } = new List<Poruka>();

    public virtual ICollection<Posjetum> Posjeta { get; } = new List<Posjetum>();

    public virtual ICollection<Ugovor> UgovorPodnosiocUgovoras { get; } = new List<Ugovor>();

    public virtual ICollection<Ugovor> UgovorUgovornaStrankas { get; } = new List<Ugovor>();

    public virtual Uloga? Uloga { get; set; }
}

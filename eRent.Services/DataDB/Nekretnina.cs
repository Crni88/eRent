using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Nekretnina
{
    public int NekretninaId { get; set; }

    public int KorisnikNekretnina { get; set; }

    public string NazivNekretnine { get; set; } = null!;

    public int Cijena { get; set; }

    public DateTime DatumObjave { get; set; }

    public int BrojSoba { get; set; }

    public bool? Namještena { get; set; }

    public string? Opis { get; set; }

    public int LokacijaId { get; set; }

    public bool? Izdvojena { get; set; }

    public virtual Korisnik KorisnikNekretninaNavigation { get; set; } = null!;

    public virtual Lokacija Lokacija { get; set; } = null!;

    public virtual ICollection<NekretninaRezervacija> NekretninaRezervacijas { get; } = new List<NekretninaRezervacija>();

    public virtual ICollection<NekretninaSlika> NekretninaSlikas { get; } = new List<NekretninaSlika>();

    public virtual ICollection<NekretninaTagovi> NekretninaTagovis { get; } = new List<NekretninaTagovi>();

    public virtual ICollection<Ogla> Oglas { get; } = new List<Ogla>();

    public virtual ICollection<Posjetum> Posjeta { get; } = new List<Posjetum>();

    public virtual ICollection<Ugovor> Ugovors { get; } = new List<Ugovor>();
}

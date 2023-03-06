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

    public bool? Izdvojena { get; set; }

    public bool? Popunjena { get; set; }

    public string? Username { get; set; }

    public string? Grad { get; set; }

    public int? Brojkvadrata { get; set; }

    public string? Slika { get; set; }

    public virtual Korisnik KorisnikNekretninaNavigation { get; set; } = null!;

    public virtual ICollection<NekretninaKorisnik> NekretninaKorisniks { get; } = new List<NekretninaKorisnik>();

    public virtual ICollection<NekretninaRezervacija> NekretninaRezervacijas { get; } = new List<NekretninaRezervacija>();

    public virtual ICollection<NekretninaTagovi> NekretninaTagovis { get; } = new List<NekretninaTagovi>();

    public virtual ICollection<PaymentRequest> PaymentRequests { get; } = new List<PaymentRequest>();

    public virtual ICollection<Posjetum> Posjeta { get; } = new List<Posjetum>();

    public virtual ICollection<Rejting> Rejtings { get; } = new List<Rejting>();

    public virtual ICollection<Rezervacija> Rezervacijas { get; } = new List<Rezervacija>();

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();

    public virtual ICollection<Ugovor> Ugovors { get; } = new List<Ugovor>();
}

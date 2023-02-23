using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class Ogla
{
    public int OglasId { get; set; }

    public int OglasNekretnina { get; set; }

    public DateTime DatumObjaveOglaasa { get; set; }

    public string OglasNaslov { get; set; } = null!;

    public bool? Obnovljen { get; set; }

    public DateTime? DatumObnove { get; set; }

    public string? KratkiOpis { get; set; }

    public virtual ICollection<OglasKorisnik> OglasKorisniks { get; } = new List<OglasKorisnik>();

    public virtual Nekretnina OglasNekretninaNavigation { get; set; } = null!;
}

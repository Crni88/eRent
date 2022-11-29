using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class NekretninaSlika
{
    public int NekretninaSlikaId { get; set; }

    public int Slika { get; set; }

    public int Nekretnina { get; set; }

    public virtual Nekretnina NekretninaNavigation { get; set; } = null!;

    public virtual Slika SlikaNavigation { get; set; } = null!;
}

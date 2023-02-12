using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Slika
{
    public int SlikaId { get; set; }

    public string? SlikaIme { get; set; }

    public byte[]? Slika1 { get; set; }

    public virtual ICollection<NekretninaSlika> NekretninaSlikas { get; } = new List<NekretninaSlika>();
}

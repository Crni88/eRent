using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class NekretninaTagovi
{
    public int NtId { get; set; }

    public int NekretninaId { get; set; }

    public int TagId { get; set; }

    public virtual Nekretnina Nekretnina { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}

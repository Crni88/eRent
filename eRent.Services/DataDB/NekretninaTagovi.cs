﻿using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class NekretninaTagovi
{
    public int TaggingsId { get; set; }

    public int NekretninaId { get; set; }

    public int TagId { get; set; }

    public virtual Nekretnina Nekretnina { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}

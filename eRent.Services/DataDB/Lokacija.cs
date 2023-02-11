using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Lokacija
{
    public int LokacijaId { get; set; }

    public string Adresa { get; set; } = null!;

    public string Regija { get; set; } = null!;

    public string Grad { get; set; } = null!;

    public string Drzava { get; set; } = null!;

    public int? PostanskiBroj { get; set; }
}

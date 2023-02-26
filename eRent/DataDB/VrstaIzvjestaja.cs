using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class VrstaIzvjestaja
{
    public int VrstaIzvjestajaId { get; set; }

    public string NazivIzvjestaja { get; set; } = null!;

    public virtual ICollection<Izvjestaj> Izvjestajs { get; } = new List<Izvjestaj>();
}

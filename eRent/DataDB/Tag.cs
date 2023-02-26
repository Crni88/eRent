using System;
using System.Collections.Generic;

namespace eRent.DataDB;

public partial class Tag
{
    public int TagId { get; set; }

    public string TagName { get; set; } = null!;

    public virtual ICollection<NekretninaTagovi> NekretninaTagovis { get; } = new List<NekretninaTagovi>();
}

using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Tag
{
    public int TagsId { get; set; }

    public string TagName { get; set; } = null!;

    public virtual ICollection<NekretninaTagovi> NekretninaTagovis { get; } = new List<NekretninaTagovi>();
}

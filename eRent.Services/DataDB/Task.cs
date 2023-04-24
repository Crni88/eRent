using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class Task
{
    public int TaskId { get; set; }

    public int NekretninaTask { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DueDate { get; set; }

    public string? Status { get; set; }

    public string? Priority { get; set; }

    public bool? IsActive { get; set; }

    public virtual Nekretnina NekretninaTaskNavigation { get; set; } = null!;
}

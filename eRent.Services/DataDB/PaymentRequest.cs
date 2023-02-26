using System;
using System.Collections.Generic;

namespace eRent.Services.DataDB;

public partial class PaymentRequest
{
    public int PaymentRequestId { get; set; }

    public int NekretninaPayment { get; set; }

    public string? Komentar { get; set; }

    public double Iznos { get; set; }

    public bool? Mjesecno { get; set; }

    public string Nekretnina { get; set; } = null!;

    public virtual Nekretnina NekretninaPaymentNavigation { get; set; } = null!;
}

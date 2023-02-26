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

    public int? KorisnikPaymentId { get; set; }

    public bool? IsProcessed { get; set; }

    public string? Naslov { get; set; }

    public virtual Korisnik? KorisnikPayment { get; set; }

    public virtual Nekretnina NekretninaPaymentNavigation { get; set; } = null!;
}

namespace eRent.Models
{
    public class PaymentRequestModel
    {
        public int PaymentRequestId { get; set; }

        public string Naslov { get; set; }

        public int? KorisnikPaymentId { get; set; }

        public bool? IsProcessed { get; set; }
        public int NekretninaPayment { get; set; }

        public string Komentar { get; set; }

        public double Iznos { get; set; }

        public bool? Mjesecno { get; set; }

        public string PaymentId { get; set; }

        public string Nekretnina { get; set; }
    }
}

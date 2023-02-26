namespace eRent.Models
{
    public class PaymentRequestModel
    {
        public int NekretninaPayment { get; set; }

        public string Komentar { get; set; }

        public double Iznos { get; set; }

        public bool? Mjesecno { get; set; }

        public string Nekretnina { get; set; }
    }
}

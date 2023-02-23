namespace eRent.Models.Requests.Rejting
{
    public class RejtingInsertRequest
    {
        public int KorisnikPrim { get; set; }

        public int KorisnikSec { get; set; }

        public int NekretninaRejting { get; set; }
        public float Rejting1 { get; set; }

        public string Komentar { get; set; }

    }
}

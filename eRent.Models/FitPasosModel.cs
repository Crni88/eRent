namespace eRent.Models
{
    public class FitPasosModel
    {
        public int PasosId { get; set; }

        public int KorisnikId { get; set; }

        public System.DateTime DatumIzdavanja { get; set; }

        public System.DateTime DatumIsteka { get; set; }

        public bool IsValid { get; set; }

        public virtual KorisnikModel Korisnik { get; set; }
    }
}

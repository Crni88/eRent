using System;

namespace eRent.Models
{
    public class FitPasosModel
    {
        public int PasosId { get; set; }

        public int KorisnikId { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public bool IsValid { get; set; }
        public KorisnikModel Korisnik { get; set; }
    }
}

using System;

namespace eRent.Models.Requests.FitPasos
{
    public class FITPasosInsertRequest
    {
        public int KorisnikId { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public bool IsValid { get; set; }
    }
}

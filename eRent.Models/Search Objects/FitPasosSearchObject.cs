using System;

namespace eRent.Models.Search_Objects
{
    public class FitPasosSearchObject : BaseSearchObject
    {
        public int? PasosId { get; set; }

        public int? KorisnikId { get; set; }

        public DateTime? DatumIzdavanja { get; set; }

        public bool? IsValid { get; set; }
    }
}

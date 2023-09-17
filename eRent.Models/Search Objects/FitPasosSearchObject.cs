namespace eRent.Models.Search_Objects
{
    public class FitPasosSearchObject : BaseSearchObject
    {
        public int? PasosId { get; set; }

        public int? KorisnikId { get; set; }

        public System.DateTime? DatumIzdavanja { get; set; }

        public System.DateTime? DatumIsteka { get; set; }

        public bool? IsValid { get; set; }

    }
}

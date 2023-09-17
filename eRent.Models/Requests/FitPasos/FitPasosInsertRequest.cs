namespace eRent.Models.Requests.FitPasos
{
    public class FitPasosInsertRequest
    {
        public int KorisnikId { get; set; }
        public System.DateTime DatumIzdavanja { get; set; }
        public System.DateTime DatumIsteka { get; set; }
        public bool IsValid { get; set; }
    }
}

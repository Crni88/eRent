namespace eRent.Models.Requests.Korisnik
{
    public class KorisnikUpdateRequest
    {
        public string KorsnikIme { get; set; }
        public string KorisnikPrezime { get; set; }
        public double? Rejting { get; set; }
    }
}

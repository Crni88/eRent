namespace eRent.Models.Requests
{
    public class KorisnikInsertRequest
    {
        public string KorsnikIme { get; set; }

        public string KorisnikPrezime { get; set; }

        public string Email { get; set; }

        public int? UlogaId { get; set; }

        public double? Rejting { get; set; }

        public string LozinkaHash { get; set; }

        public string LozinkaSalt { get; set; }
    }
}

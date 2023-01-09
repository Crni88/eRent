namespace eRent.Models
{
    public partial class KorisnikModel
    {
        public int KorisnikId { get; set; }
        
        public string KorsnikIme { get; set; }

        public string KorisnikPrezime { get; set; }

        public string Email { get; set; }

        public int? UlogaId { get; set; }

        public double? Rejting { get; set; }

        public string Username { get; set; }
    }
}

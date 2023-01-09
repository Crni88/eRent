namespace eRent.Models.Search_Objects
{
    public class KorisnikSearchObject : BaseSearchObject
    {
        public int KorisnikId { get; set; }
        public string KorsnikIme { get; set; }
        public string KorsnikPrezime { get; set; }
        public string Email { get; set; }
        public int UlogaId { get; set; }
        public int Rejting { get; set; }
        public string Username { get; set; }

        public string NameFTS { get; set; }
    }
}

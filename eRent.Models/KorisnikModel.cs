namespace eRent.Models
{
    public partial class KorisnikModel
    {

        //Apstraktni tip podatka zajedno sa njegovom implementacijom i reprezentacijom
        public int KorisnikId { get; set; }
        
        public string KorsnikIme { get; set; }

        public string KorisnikPrezime { get; set; }

        public string Email { get; set; }

        public int? UlogaId { get; set; }

        public double? Rejting { get; set; }

        public string Username { get; set; }
        public string FcmDeviceToken { get; set; }
    }
}

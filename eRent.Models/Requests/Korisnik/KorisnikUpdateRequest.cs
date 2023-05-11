using System.ComponentModel.DataAnnotations;

namespace eRent.Models.Requests.Korisnik
{
    public class KorisnikUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string KorsnikIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KorisnikPrezime { get; set; }
        public string Uloga { get; set; }
        public string FcmDeviceToken { get; set; }
        public bool? IsActive { get; set; }
    }
}

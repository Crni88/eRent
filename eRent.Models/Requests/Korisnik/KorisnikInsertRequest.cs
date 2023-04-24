using System.ComponentModel.DataAnnotations;

namespace eRent.Models.Requests.Korisnik
{
    public class KorisnikInsertRequest
    {
        [Required(AllowEmptyStrings = false)]

        public string KorsnikIme { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string KorisnikPrezime { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }

        [MinLength(3)]
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }

        public string Uloga { get; set; }

        public double? Rejting { get; set; }

        public string Password { get; set; }


        public bool? IsActive { get; set; }


    }
}

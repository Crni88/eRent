using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests
{
    public class KorisnikInsertRequest
    {
        public string KorsnikIme { get; set; }

        public string KorisnikPrezime { get; set; }

        public string Email { get; set; }

        public int? UlogaId { get; set; }

        public double? Rejting { get; set; }
    }
}

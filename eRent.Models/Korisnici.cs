using System;
using System.Collections.Generic;

namespace eRent.Models
{
    public partial class KorisnikModel
    {
        public string KorsnikIme { get; set; } 

        public string KorisnikPrezime { get; set; }

        public string Email { get; set; }

        public int? UlogaId { get; set; }

        public double? Rejting { get; set; }
    }
}

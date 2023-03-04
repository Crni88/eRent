using System;

namespace eRent.Models.Requests.Rezervacija
{
    public class RezervacijaUpdateRequest
    {
        public int RezervacijaId { get; set; }

        //public bool? MjesecnaRezervacija { get; set; }

        //public DateTime? DatumPocetka { get; set; }

        //public DateTime? DatumKraja { get; set; }

        public bool? Odobrena { get; set; }
    }
}

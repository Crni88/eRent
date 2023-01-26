using System;

namespace eRent.Models.Requests.Rezervacija
{
    public class RezervacijaUpdateRequest
    {
        public bool? MjesecnaRezervacija { get; set; }

        public DateTime? DatumPocetka { get; set; }

        public DateTime? DatumKraja { get; set; }
    }
}

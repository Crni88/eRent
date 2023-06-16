using System;

namespace eRent.Models.Requests.Rezervacija
{
    public class RezervacijaInsertRequest
    {
        public int NekretninaId { get; set; }

        public bool? MjesecnaRezervacija { get; set; }

        public DateTime? DatumPocetka { get; set; }

        public DateTime? DatumKraja { get; set; }

        public string ImePrezime { get; set; }

        public string BrojTelefona { get; set; }

        public bool? Odobrena { get; set; }
        public bool? Otkazana { get; set; }
        public bool? Odbijena { get; set; }
    }
}

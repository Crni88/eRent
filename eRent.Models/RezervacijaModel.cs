using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models
{
    public class RezervacijaModel
    {
        public int NekretninaId { get; set; }

        public bool? MjesecnaRezervacija { get; set; }

        public DateTime? DatumPocetka { get; set; }

        public DateTime? DatumKraja { get; set; }

        public string ImePrezime { get; set; }

        public string BrojTelefona { get; set; }

        public string Nazivnekretnine { get; set; }
    }
}

﻿using System;

namespace eRent.Models
{
    public class RezervacijaModel
    {
        public int RezervacijaId { get; set; }
        public int NekretninaId { get; set; }
        public int? KorisnikId { get; set; }


        public bool MjesecnaRezervacija { get; set; }

        public DateTime? DatumPocetka { get; set; }

        public DateTime? DatumKraja { get; set; }

        public string ImePrezime { get; set; }

        public string BrojTelefona { get; set; }

        public string Nazivnekretnine { get; set; }

        public bool? Odobrena { get; set; }
        public bool? Odbijena { get; set; }
        public NekretninaModel Nekretnina { get; set; }

    }
}

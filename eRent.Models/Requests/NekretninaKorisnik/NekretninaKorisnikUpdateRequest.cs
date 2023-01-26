﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests.NekretninaKorisnik
{
    public class NekretninaKorisnikUpdateRequest
    {
        public int NekretninaKorisnikSlika { get; set; }

        public string ImeKorisnika { get; set; }

        public string PrezimeKorisnika { get; set; }

        public string BrojTelefona { get; set; }

        public DateTime? DatumUseljenja { get; set; }

        public DateTime? DatumIseljenja { get; set; }
    }
}
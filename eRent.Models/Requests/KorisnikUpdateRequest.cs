﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests
{
    public class KorisnikUpdateRequest
    {
        public string KorsnikIme { get; set; }
        public string KorisnikPrezime { get; set; }
        public double? Rejting { get; set; }
    }
}

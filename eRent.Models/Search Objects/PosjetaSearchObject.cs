using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Search_Objects
{
    public class PosjetaSearchObject : BaseSearchObject
    {
        public int? NekretninaId { get; set; }
        public int? KorisnikId { get; set; }
        public bool? Otkazana { get; set; }
    }
}

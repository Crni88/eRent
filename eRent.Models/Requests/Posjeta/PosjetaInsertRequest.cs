using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests.Posjeta
{
    public class PosjetaInsertRequest
    {
        public int? KorisnikId { get; set; }

        public int? NekretninaId { get; set; }

        public DateTime? DatumPosjete { get; set; }

        public string vrijemePosjete { get; set; }

    }
}

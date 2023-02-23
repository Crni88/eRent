using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests.Posjeta
{
    public class PosjetaUpdateRequest
    {
        public int PosjetaId { get; set; }

        public DateTime? DatumPosjete { get; set; }
        public string vrijemePosjete { get; set; }

    }
}

using System;

namespace eRent.Models.Requests.Posjeta
{
    public class PosjetaUpdateRequest
    {
        public int PosjetaId { get; set; }

        public DateTime? DatumPosjete { get; set; }
        public string vrijemePosjete { get; set; }
        public bool? Otkazana { get; set; }
    }
}

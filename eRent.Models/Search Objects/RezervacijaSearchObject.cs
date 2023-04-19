using System;

namespace eRent.Models.Search_Objects
{
    public class RezervacijaSearchObject:BaseSearchObject
    {
        public int NekretninaId { get; set; }
        public DateTime? DatumPocetka { get; set; }

        public DateTime? DatumKraja { get; set; }
    }
}

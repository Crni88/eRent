using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests
{
    public class UgovorUpsertRequest
    {
        public int PodnosiocUgovoraId { get; set; }
        public int NekretninaId { get; set; }
        public string UgovornaStranka { get; set; }
        public string PodnosiocUgovora { get; set; }
        public DateTime? DatumSklapanjaUgovora { get; set; }
        public DateTime? DatumIstekaUgovora { get; set; }
    }
}

using System;

namespace eRent.Models
{
    public class PosjetaModel
    {
        public int PosjetaId { get; set; }

        public int? KorisnikId { get; set; }

        public int? NekretninaId { get; set; }

        public string NazivNekretnine { get; set; }

        public DateTime? DatumPosjete { get; set; }

        public string vrijemePosjete { get; set; }

        public string KorisnikImePrezime { get; set; }

    }
}

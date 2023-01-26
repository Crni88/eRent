using System;

namespace eRent.Models.Requests.NekretninaKorisnik
{
    public class NekretninaKorisnikInsertRequest
    {
        //public int NekretninaKorisnikId { get; set; }

        public int Nekretnina { get; set; }

        public int NekretninaKorisnikSlika { get; set; }

        public string ImeKorisnika { get; set; }

        public string PrezimeKorisnika { get; set; }

        public string BrojTelefona { get; set; }

        public DateTime? DatumUseljenja { get; set; }

        public DateTime? DatumIseljenja { get; set; }

    }
}

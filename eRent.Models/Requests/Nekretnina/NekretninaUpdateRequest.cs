using System;

namespace eRent.Models.Requests
{
    public class NekretninaUpdateRequest
    {
        //public int KorisnikNekretnina { get; set; }

        //public string NazivNekretnine { get; set; }

        public int Cijena { get; set; }

        public DateTime DatumObjave { get; set; }

        public int BrojSoba { get; set; }

        public bool? Namještena { get; set; }

        //public int LokacijaId { get; set; }

        public bool? Izdvojena { get; set; }
        public bool? Popunjena { get; set; }

        public string Opis { get; set; }

    }
}

using System;

namespace eRent.Models.Search_Objects
{
    public class NekretninaSearchObject : BaseSearchObject
    {
        public int NekretninaId { get; set; }

        public string Username { get; set; }

        public int KorisnikNekretnina { get; set; }

        public string NazivNekretnine { get; set; }

        public int Cijena { get; set; }

        public int CijenaMin { get; set; }
        public int CijenaMax { get; set; }

        public DateTime DatumObjave { get; set; }

        public int BrojSoba { get; set; }

        public bool? Namještena { get; set; }

        public int LokacijaId { get; set; }

        public string NameFTS { get; set; }

        //public bool? Izdvojena { get; set; }
    }
}

using System;

namespace eRent.Models.Requests
{
    public class NekretninaUpdateRequest
    {
        public string NazivNekretnine { get; set; }
        public int Cijena { get; set; }
        public DateTime DatumObjave { get; set; }
        public int BrojSoba { get; set; }
        public bool? Namještena { get; set; }
        public bool? Izdvojena { get; set; }
        public bool? Popunjena { get; set; }
        public string Opis { get; set; }
        public string Grad { get; set; }
        public int Brojkvadrata { get; set; }
    }
}

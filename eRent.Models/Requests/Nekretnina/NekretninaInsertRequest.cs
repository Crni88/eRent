using System;
using System.Collections.Generic;

namespace eRent.Models.Requests
{
    //TODO Add Nekretnina Image Property
    public class NekretninaInsertRequest
    {
        public int KorisnikNekretnina { get; set; }
        public string Username { get; set; }

        public string NazivNekretnine { get; set; }

        public int Cijena { get; set; }

        public DateTime DatumObjave { get; set; }

        public int BrojSoba { get; set; }

        public bool? Namještena { get; set; }

        public int LokacijaId { get; set; }

        public bool? Izdvojena { get; set; }

        public bool? Popunjena { get; set; }

        public string Opis { get; set; }
        public string Grad { get; set; }

        public List<int> TagIdList { get; set; } = new List<int> { };

        //TODO Add Property that will be public List<int> Nekretnina slike
        //Possible List<Slika>
    }
}

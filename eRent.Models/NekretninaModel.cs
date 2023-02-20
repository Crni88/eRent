using System;
using System.Drawing;

namespace eRent.Models
{
    public partial class NekretninaModel
    {
        public int NekretninaId { get; set; }

        public int KorisnikNekretnina { get; set; }

        public string NazivNekretnine { get; set; }

        public int Cijena { get; set; }

      

        public DateTime DatumObjave { get; set; }

        public int BrojSoba { get; set; }

        public bool Namještena { get; set; }

        public string Opis { get; set; }

        public bool? Izdvojena { get; set; }

        public bool? Popunjena { get; set; }

        public string Username { get; set; }

        public string Grad { get; set; }

        public string Slika { get; set; }

        public int? Brojkvadrata { get; set; }

    }
}
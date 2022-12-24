using System;

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

        public bool? Namještena { get; set; }

        public string Opis { get; set; }

        public int LokacijaId { get; set; }

        public bool? Izdvojena { get; set; }

        public bool? Popunjena { get; set; }

        public virtual KorisnikModel KorisnikNekretninaNavigation { get; set; }

        public virtual LokacijaModel Lokacija { get; set; }
    }
}
namespace eRent.Models
{
    public partial class LokacijaModel
    {
        public int LokacijaId { get; set; }

        public string Adresa { get; set; }

        public string Regija { get; set; }

        public string Grad { get; set; }

        public string Drzava { get; set; }

        public int? PostanskiBroj { get; set; }

        public virtual NekretninaModel Nekretninas { get; set; }

    }
}
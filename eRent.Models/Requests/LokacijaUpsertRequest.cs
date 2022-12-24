namespace eRent.Models.Requests
{
    public class LokacijaUpsertRequest
    {
        public string Adresa { get; set; }

        public string Regija { get; set; }

        public string Grad { get; set; }

        public string Drzava { get; set; }

        public int? PostanskiBroj { get; set; }
    }
}

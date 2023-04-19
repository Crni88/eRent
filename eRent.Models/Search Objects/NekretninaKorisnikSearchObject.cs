namespace eRent.Models.Search_Objects
{
    public class NekretninaKorisnikSearchObject:BaseSearchObject
    {
        public int NekretninaId { get; set; }
        public bool? IsActive { get; set; }

    }
}

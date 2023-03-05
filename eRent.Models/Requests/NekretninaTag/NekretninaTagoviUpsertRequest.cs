namespace eRent.Models.Requests.NekretninaTag
{
    public class NekretninaTagoviUpsertRequest
    {
        public int NekretninaId { get; set; }

        public int TagId { get; set; }

        public bool? IsActive { get; set; }
    }
}

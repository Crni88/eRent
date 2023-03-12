namespace eRent.Models.Requests.NekretninaTag
{
    public class NekretninaTagUpdateRequest
    {
        //public int NtId { get; set; }
        public int NekretninaId { get; set; }

        public int TagId { get; set; }

        public bool? IsActive { get; set; }
    }
}

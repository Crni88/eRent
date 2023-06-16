namespace eRent.Models.Search_Objects
{
    public class TaskSearchObject : BaseSearchObject
    {
        public int NekretninaTask { get; set; }
        public bool? IsActive { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }
    }
}

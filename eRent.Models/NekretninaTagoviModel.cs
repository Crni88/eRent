using System.Collections.Generic;

namespace eRent.Models
{
    public class NekretninaTagoviModel
    {
        public int NtId { get; set; }

        public int NekretninaId { get; set; }

        public int tagID { get; set; }

        public bool? IsActive { get; set; }

        //public List<TagModel> tags { get; set; }

        //public NekretninaTagoviModel()
        //{
        //    tags = new List<TagModel>();
        //}
    }
}

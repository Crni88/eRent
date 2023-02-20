using System.Collections.Generic;

namespace eRent.Models
{
    public class NekretninaTagoviModel
    {
        public int NekretninaId { get; set; }
        public List<TagModel> tags { get; set; }

        public NekretninaTagoviModel()
        {
            tags = new List<TagModel>();
        }
    }
}

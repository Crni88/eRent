using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models
{
    public class KorisnikTagoviModel
    {
        public int KorisnikId { get; set; }

        public List<TagModel> tags { get; set; }

        public KorisnikTagoviModel()
        {
            tags = new List<TagModel>();
        }
    }
}

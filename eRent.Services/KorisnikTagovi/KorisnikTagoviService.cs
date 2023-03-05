using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.KorisnikTag;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.KorisnikTagovi
{
    public class KorisnikTagoviService :
                BaseCRUDService<KorisnikTagoviModel, DataDB.KorisnikTagovi, KorisnikTagoviSearchObject, KorisnikTagUpsertRequest, KorisnikTagUpsertRequest>, IKorisnikTagoviService
    {
        public KorisnikTagoviService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
            Context = eRentContext;
        }

        public ERentContext Context { get; set; }


        public override KorisnikTagoviModel Test(int id)
        {
            KorisnikTagoviModel korisnikTagoviModel = new KorisnikTagoviModel();
            var result = (from tag in Context.Tags
                          join nt in Context.KorisnikTagovis
                          on tag.TagId equals nt.TagId
                          where nt.KorisnikId == id
                          select tag).ToList();
            korisnikTagoviModel.KorisnikId = id;
            foreach (var x in result)
            {
                TagModel tagModel = new TagModel();
                tagModel.TagId = x.TagId;
                tagModel.TagName = x.TagName;
                korisnikTagoviModel.tags.Add(tagModel);
            }

            return korisnikTagoviModel;
        }
    }
}

using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.NekretninaTag;
using eRent.Services.DataDB;

namespace eRent.Services.NekretninaTagovi
{
    public class NekretninaTagoviService :
                BaseCRUDService<NekretninaTagoviModel, DataDB.NekretninaTagovi, NekretninaTagoviSearchObject, NekretninaTagoviInsertRequest, NekretninaTagUpdateRequest>, INekretninaTagovi
    {
        public ERentContext Context { get; set; }

        public NekretninaTagoviService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
            Context = eRentContext;
        }


        public override IQueryable<DataDB.NekretninaTagovi> AddFilter(IQueryable<DataDB.NekretninaTagovi> query, NekretninaTagoviSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.NekretninaId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.NekretninaId == search.NekretninaId);
            }
           
            return filteredQuery;
        }

        //public override NekretninaTagoviModel Test(int id)
        //{
        //    NekretninaTagoviModel nekretninaTagoviModel = new NekretninaTagoviModel();
        //    var result = (from tag in Context.Tags
        //                  join nt in Context.NekretninaTagovis
        //                  on tag.TagId equals nt.s
        //                  where nt.NekretninaId == id
        //                  select tag).ToList();
        //    nekretninaTagoviModel.NekretninaId = id;
        //    foreach (var x in result)
        //    {
        //        TagModel tagModel = new TagModel();
        //        tagModel.TagId = x.TagId;
        //        tagModel.TagName = x.TagName;
        //        nekretninaTagoviModel.tags.Add(tagModel);
        //    }

        //    return nekretninaTagoviModel;
        //}
    }
}

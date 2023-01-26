using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Tag;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Tags
{
    public class TagsService
        : BaseCRUDService<TagModel, DataDB.Tag, TagsSearchObject, TagUpsertRequest, TagUpsertRequest>, ITagsService

    {
        public TagsService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        //public override IQueryable<DataDB.Tag> AddFilter(IQueryable<DataDB.Tag> query, TagsSearchObject search = null)
        //{
        //    var filteredQuery = base.AddFilter(query, search);

        //    if (!string.IsNullOrWhiteSpace(search?.TagName))
        //    {
        //        filteredQuery = filteredQuery.Where(x => x.TagName.StartsWith(search.TagName));
        //    }
        //    return filteredQuery;
        //}
    }
}

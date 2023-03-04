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
    }
}

using eRent.Models;
using eRent.Models.Requests.Tag;
using eRent.Models.Search_Objects;
using eRent.Services.Tags;

namespace eRent.Controllers
{
    public class TagsController :
        BaseCRUDController<TagModel, TagsSearchObject, TagUpsertRequest, TagUpsertRequest>

    {
        public TagsController(ITagsService service) : base(service)
        {
        }
    }
}

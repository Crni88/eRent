using eRent.Models;
using eRent.Models.Requests.Tag;
using eRent.Models.Search_Objects;

namespace eRent.Services.Tags
{
    public interface ITagsService : ICRUDService<TagModel, TagsSearchObject, TagUpsertRequest, TagUpsertRequest>
    {
    }
}

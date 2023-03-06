using eRent.Models;
using eRent.Models.Requests.Tag;
using eRent.Models.Requests.Task;
using eRent.Models.Search_Objects;

namespace eRent.Services.Task
{
    public interface ITaskService : ICRUDService<TaskModel, TaskSearchObject, TaskInsertRequest, TaskUpdateRequest>
    {
    }
}

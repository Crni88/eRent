using eRent.Models;
using eRent.Models.Requests.Task;
using eRent.Models.Search_Objects;
using eRent.Services.Task;

namespace eRent.Controllers
{
    public class TaskController :
        BaseCRUDController<TaskModel, TaskSearchObject, TaskInsertRequest, TaskUpdateRequest>

    {
        public TaskController(ITaskService service) : base(service)
        {
        }
    }
}

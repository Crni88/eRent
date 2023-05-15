using eRent.Models;
using eRent.Models.Requests.Task;
using eRent.Models.Search_Objects;
using eRent.Services.Task;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    public class TaskController :
        BaseAdminCRUDController<TaskModel, TaskSearchObject, TaskInsertRequest, TaskUpdateRequest>

    {
        public TaskController(ITaskService service) : base(service)
        {
        }
    }
}

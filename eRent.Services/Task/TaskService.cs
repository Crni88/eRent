using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Task;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Task
{
    public class TaskService
        : BaseCRUDService<TaskModel, DataDB.Task, TaskSearchObject, TaskInsertRequest, TaskUpdateRequest>, ITaskService

    {
        public TaskService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }
        public override IQueryable<DataDB.Task> AddFilter(IQueryable<DataDB.Task> query, TaskSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search != null)
            {
                filteredQuery = filteredQuery.Where(x => x.NekretninaTask == search.NekretninaTask);
            }
            if (search.IsActive != null)
            {
                filteredQuery = filteredQuery.Where(x => x.IsActive == search.IsActive);

            }
            return filteredQuery;
        }
    }
}

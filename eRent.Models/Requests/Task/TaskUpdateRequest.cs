using System;

namespace eRent.Models.Requests.Task
{
    public class TaskUpdateRequest
    {
        public int TaskId { get; set; }

        public int NekretninaTask { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }
    }
}

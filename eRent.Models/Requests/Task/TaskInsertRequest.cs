using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests.Task
{
    public class TaskInsertRequest
    {
        public int NekretninaTask { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }
        public bool? IsActive { get; set; }

    }
}

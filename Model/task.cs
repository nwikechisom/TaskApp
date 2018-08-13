using System;

namespace TaskApp.Model
{
    public class task
    {
        public int taskId { get; set; }

        public string OwnerId { get; set; }

        public string taskTitle { get; set; }

        public string taskDescription { get; set; }

        public string EmpAssignedId { get; set; }

        public string EmpAssignedName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Project.UI.Models
{
    public class ToDoStepVM
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public string ToDoListId { get; set; }
    }
}

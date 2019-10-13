using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Project.UI.Models
{
    public class ToDoListVM
    {
        public string Id { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public string Name { get; set; }
    }
}

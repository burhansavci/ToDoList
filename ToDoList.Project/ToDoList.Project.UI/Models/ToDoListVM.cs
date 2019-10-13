using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Project.Models.Entities;

namespace ToDoList.Project.UI.Models
{
    public class ToDoListVM
    {
        public List<Project.Models.Entities.ToDoList> ToDoLists { get; set; }
        public Project.Models.Entities.ToDoList ToDoList { get; set; }
        public List<ToDoStep> ToDoSteps{ get; set; }
    }
}

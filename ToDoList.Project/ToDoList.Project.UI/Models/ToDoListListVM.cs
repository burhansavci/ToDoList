using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Project.Models.Entities;

namespace ToDoList.Project.UI.Models
{
    public class ToDoListListVM
    {
        public List<ToDoListVM> ToDoLists { get; set; }
        public ToDoListVM ToDoList { get; set; }
        public List<ToDoStepVM> ToDoSteps{ get; set; }
    }
}

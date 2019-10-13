using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDoList.Project.Models.Entities
{   
    public class ToDoList:IEntity
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "DueDate")]
        public DateTime Duedate__c { get; set; }

        [Display(Name = "IsCompleted")]
        public bool IsCompleted__c { get; set; }

        [Display(Name = "Name")]
        public string Name__c { get; set; }

        [Display(Name ="ToDoSteps")]
        public List<ToDoStep> ToDoSteps__r { get; set; }
    }
}

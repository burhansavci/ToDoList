using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDoList.Project.Models.Entities
{
    public class ToDoStep:IEntity
    {
        [Key]
        public string Id { get; set; }

        [Display(Name ="Description")]
        public string Description__c { get; set; }

        [Display(Name ="DueDate")]
        public DateTime DueDate__c { get; set; }

        [Display(Name ="Title")]
        public string Title__c { get; set; }

        [Display(Name = "IsCompleted")]
        public bool IsCompleted__c { get; set; }

        [Display(Name ="ToDoListId")]
        public string ToDoListId__c { get; set; }
    }
}

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

        public string Description__c { get; set; }

        public DateTime DueDate__c { get; set; }

        public string Title__c { get; set; }

        public bool IsCompleted__c { get; set; }
  
        public string ToDoListId__c { get; set; }
    }
}

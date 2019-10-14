using Newtonsoft.Json;
using Salesforce.Common.Models.Json;
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

        public DateTime Duedate__c { get; set; }

        public bool IsCompleted__c { get; set; }

        public string Name__c { get; set; }

        public QueryResult<ToDoStep> ToDoSteps__r { get; set; }
    }
}

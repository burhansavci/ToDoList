using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDoList.Project.Models.Entities
{
    public interface IEntity
    {
        [Key]
        [Updateable(false)]
        public string Id { get; set; }
    }
}

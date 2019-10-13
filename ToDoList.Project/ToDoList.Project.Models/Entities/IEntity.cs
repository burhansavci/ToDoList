using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDoList.Project.Models.Entities
{
    public interface IEntity
    {
        [Key]
        public string Id { get; set; }
    }
}

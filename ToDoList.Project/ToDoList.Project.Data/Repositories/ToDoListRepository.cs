using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Project.Models.Contracts;
using ToDoList.Project.Models.CustomConfig;
using ToDoList.Project.Models.Entities;
namespace ToDoList.Project.Data.Repositories
{
    public class ToDoListRepository:Repository<Models.Entities.ToDoList>,IToDoListRepository
    {
        public ToDoListRepository(IOptions<MyConfig> config):base(config)
        {

        }
    }
}
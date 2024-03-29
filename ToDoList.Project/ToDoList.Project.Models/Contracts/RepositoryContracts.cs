﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Project.Models.Entities;

namespace ToDoList.Project.Models.Contracts
{
    public interface IToDoListRepository : IRepository<Entities.ToDoList> {
        Task<Entities.ToDoList> GetWithChild(string parentId, string sfChildObject, string[] includedFieldsParent, params string[] includedFieldsChild);
    }
    public interface IToDoStepRepository : IRepository<ToDoStep> { }
}

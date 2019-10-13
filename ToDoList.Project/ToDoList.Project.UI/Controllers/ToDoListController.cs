using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Project.Models.Contracts;

namespace ToDoList.Project.UI.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IToDoListRepository _toDoListRepo;
        public ToDoListController(IToDoListRepository toDoListRepo)
        {
            _toDoListRepo = toDoListRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetToDoList()
        {
            var model=await _toDoListRepo.Get("ToDoList__c", "Name__c", "IsCompleted__c", "DueDate__c");
            return View(model);
        }
    }
}
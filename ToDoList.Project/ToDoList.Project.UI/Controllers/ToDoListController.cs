using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Project.Models.Contracts;
using ToDoList.Project.Models.Entities;
using ToDoList.Project.UI.Models;

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
        public async Task<IActionResult> GetToDoList(string parentId)
        {
            var toDoList = await _toDoListRepo.GetWithChild(parentId, "toDoSteps__r", new string[] { "Name__c", "DueDate__c", "IsCompleted__c" }, "Title__c", "Description__c", "DueDate__c", "IsCompleted__c");
            if (toDoList.ToDoSteps__r != null)
                return View(new ToDoListVM
                {
                    ToDoList = toDoList,
                    ToDoSteps = toDoList.ToDoSteps__r.Records

                });
            else
            {
                return View(new ToDoListVM
                {
                    ToDoList = toDoList,
                    ToDoSteps = new List<ToDoStep>()
                }) ;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToDoList()
        {
            return View();
        }
    }
}
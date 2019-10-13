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
                return View(new ToDoListListVM
                {
                    ToDoList = new ToDoListVM
                    {
                        Id = toDoList.Id,
                        DueDate = toDoList.Duedate__c,
                        IsCompleted = toDoList.IsCompleted__c,
                        Name = toDoList.Name__c
                    },
                    ToDoSteps = toDoList.ToDoSteps__r.Records

                });
            else
            {
                return View(new ToDoListListVM
                {
                    ToDoList = new ToDoListVM
                    {
                        Id = toDoList.Id,
                        DueDate = toDoList.Duedate__c,
                        IsCompleted = toDoList.IsCompleted__c,
                        Name = toDoList.Name__c
                    },
                    ToDoSteps = new List<ToDoStep>()
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToDoList(ToDoListVM model)
        {
            var toDoList = new Project.Models.Entities.ToDoList
            {
                Name__c = model.Name,
                Duedate__c = model.DueDate,
                IsCompleted__c = model.IsCompleted
            };
            var response = await _toDoListRepo.Insert(toDoList);
            if (response.Success)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> UpdateToDoList(ToDoListVM model)
        {
            var toDoList = new Project.Models.Entities.ToDoList
            {
                Id = model.Id,
                Name__c = model.Name,
                Duedate__c = model.DueDate,
                IsCompleted__c = model.IsCompleted
            };
            var response = await _toDoListRepo.Update(toDoList);
            if (response.Success)
            {
                return RedirectToAction("GetToDoList", new { parentId = model.Id });
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> DeleteToDoList(string id,string sfObject)
        {
             var response=await _toDoListRepo.Delete(id, sfObject);
            if (response)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

    }
}
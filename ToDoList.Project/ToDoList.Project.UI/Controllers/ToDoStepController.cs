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
    public class ToDoStepController : Controller
    {
        private readonly IToDoStepRepository _toDoStepRepo;
        public ToDoStepController(IToDoStepRepository toDoStepRepo)
        {
            _toDoStepRepo = toDoStepRepo;
        }
        public async Task<IActionResult> AddToDoStep(ToDoStepVM model)
        {
            var toDoStep = new ToDoStep
            {
                Description__c = model.Description,
                DueDate__c = model.DueDate,
                IsCompleted__c = model.IsCompleted,
                Title__c = model.Title,
                ToDoListId__c = model.ToDoListId
            };
            var response = await _toDoStepRepo.Insert(toDoStep);
            if (response.Success)
            {
                return RedirectToAction("GetToDoList", "ToDoList", new { parentId = model.ToDoListId });
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> UpdateToDoStep(ToDoStepVM model)
        {
            var toDoStep = new ToDoStep
            {
                Id = model.Id,
                Description__c = model.Description,
                DueDate__c = model.DueDate,
                IsCompleted__c = model.IsCompleted,
                Title__c = model.Title,
                ToDoListId__c = model.ToDoListId
            };
            var response = await _toDoStepRepo.Update(toDoStep);
            if (response.Success)
            {
                return RedirectToAction("GetToDoList", "ToDoList", new { parentId = model.ToDoListId });
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteToDoStep(string parentId, string Id, string sfObject)
        {
            var response = await _toDoStepRepo.Delete(Id, sfObject);
            if (response)
            {
                return RedirectToAction("GetToDoList", "ToDoList", new { parentId = parentId });
            }
            else
            {
                return View();
            }
        }
    }
}
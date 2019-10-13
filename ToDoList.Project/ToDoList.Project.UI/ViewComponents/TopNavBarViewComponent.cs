using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Project.Models.Contracts;
using ToDoList.Project.UI.Models;

namespace ToDoList.Project.UI.ViewComponents
{
    public class TopNavBarViewComponent:ViewComponent
    {
        private readonly IToDoListRepository _toDoListRepo;
        public TopNavBarViewComponent(IToDoListRepository toDoListRepo)
        {
            _toDoListRepo = toDoListRepo;
        }
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var toDoLists =  await _toDoListRepo.Get("ToDoList__c","Name__c");
            return View(new ToDoListVM
            {
                ToDoLists = toDoLists
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ToDoList.Project.Data.Service_References.Salesforce;
using ToDoList.Project.Models.Contracts;
using ToDoList.Project.Models.CustomConfig;
using ToDoList.Project.UI.Models;


namespace ToDoList.Project.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoListRepository _toDoListRepo;
        public HomeController(ILogger<HomeController> logger,IToDoListRepository toDoListRepo)
        {
            _logger = logger;
            _toDoListRepo = toDoListRepo;
        }

        public async Task<IActionResult> Index()
        {
            var sfObject = await _toDoListRepo.Get("ToDoList__c","DueDate__c","Name__c");
            var sfObject2 = await _toDoListRepo.GetById("a063j00001fDvVcAAK","ToDoList__c","DueDate__c");
            //  var sfObject3 = new ToDoList.Project.Models.Entities.ToDoList { Duedate__c = DateTime.Now, IsCompleted__c = false, Name__c = "Deneme2" };
            //await  _toDoListRepo.Insert(sfObject3);
            //   var sfObject4 = sfObject2;
            //   sfObject4.Name__c = "degistirme";
            //await _toDoListRepo.Update(sfObject4);
             await _toDoListRepo.Delete(sfObject2.Id, "ToDoList__c");


            return View(sfObject);
        }
        //"a063j00001fDvX4AAK"
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

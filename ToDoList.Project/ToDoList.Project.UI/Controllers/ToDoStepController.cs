using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Project.UI.Controllers
{
    public class ToDoStepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ToDoList.Project.UI.Models;
using ToDoList.Project.UI.Servis_References.Salesforce;

namespace ToDoList.Project.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<MyConfig> _config;
        public HomeController(ILogger<HomeController> logger, IOptions<MyConfig> config)
        {
            _logger = logger;
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            var client = await new SalesforceService(_config.Value).GetForceClient();
            var contacts = await client.QueryAsync<Contact>(
                String.Format("SELECT Id, FirstName, LastName, Phone, Email FROM Contact"));
            var sfContact = contacts.Records;
            return View(sfContact);
        }

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

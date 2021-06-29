using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeController : Controller
    {
        private readonly ILogger _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            _logger.LogInformation("Custom Information Log : from Employee Area");
            _logger.LogWarning("Warning Log : from Employee Area");
            _logger.LogError("Error Log : from Employee Area");
            _logger.LogCritical("Critical Log : from Employee Area");
            return View("Employee", new EmployeeViewModel());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Employee(EmployeeViewModel employee)
        {
            ViewBag.EmployeeId = employee.EmployeeId;
            ViewBag.EmployeeName = employee.EmployeeName;
            ViewBag.EmployeeAge = employee.EmployeeAge;

            return View("Employee", employee);
        }
    }
}
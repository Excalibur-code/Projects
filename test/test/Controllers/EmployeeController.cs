using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test.Models;
using System.Web;

using test.Models;

namespace test.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Detail()
        {
            Employee obj = new Employee()
            {
                Name = "Harsh",
                id = "21c"
            };
            return View(obj);// passed so that the value can be accessed in view page
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test.Models;
using System.Web;

namespace test.Controllers
{
    [ServiceFilter(typeof(CustomActionFilterAttribute), Order = 2)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            //  return "Test run for id =" + id;
            //  return "Test run id =" + id + " and Name =" + Request.QueryString["name"].ToString();
            //  return "id = " + id + "and name = " + name;
            // return new List<string>()
            //{
            //    "india",
            //    "us",
            //    "canada",
            //    "turkey",
            //    "australia"
            //};
            //ViewBag.Countries = new List<string>() {"india","us","canada","turkey","australia" };
            ViewData["Country"] = new List<string>() { "india", "us", "canada", "turkey", "australia" };
            return View();
        }

        public string getDetails()
        {
            return "Test run 1";
        }
        [ServiceFilter(typeof(CustomeActionFilter), Order = 1)]
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

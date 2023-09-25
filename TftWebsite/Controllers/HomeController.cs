using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TftWebsite.Models;

namespace TftWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }


        [Route("TeamPlanner")]
        public IActionResult TeamPlanner()
        {
            return View("Views/TeamPlanner/Create.cshtml");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
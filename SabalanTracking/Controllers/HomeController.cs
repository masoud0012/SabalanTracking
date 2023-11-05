using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;
using System.Diagnostics;

namespace SabalanTracking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProcess _processService;
        public HomeController(ILogger<HomeController> logger,IProcess processService)
        {
            _processService=processService;
            _logger = logger;
        }
        [Route("/")]
        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            var list = (await _processService.GetAllAsync()).Take(5).ToList();
            return View(list);
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
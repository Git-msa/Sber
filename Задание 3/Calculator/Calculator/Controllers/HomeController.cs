using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculator.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel cal)
        {
            int firstValue = cal.FirstValue;
            int secondValue = cal.SecondValue;

            if (cal.Action == "+") 
            { 
                cal.ResultValue = firstValue + secondValue;
            }
            if (cal.Action == "-")
            {
                cal.ResultValue = firstValue - secondValue;
            }
            if (cal.Action == "*")
            {
                cal.ResultValue = firstValue * secondValue;
            }
            if (cal.Action == "/")
            {
                cal.ResultValue = firstValue / secondValue;
            }
            ViewData["ResultValue"] = cal.ResultValue;

            return View();
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
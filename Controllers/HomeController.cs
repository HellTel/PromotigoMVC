using Microsoft.AspNetCore.Mvc;
using PromotigoMVC.Models;
using System.Diagnostics;

namespace PromotigoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWinnersRepository winnersRepository;

        public HomeController(ILogger<HomeController> logger, IWinnersRepository repository)
        {
            _logger = logger;
            winnersRepository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            DrawViewModel dvm= new DrawViewModel(); //  to set the default values
            return View(dvm);
        }

        [HttpPost]
        public IActionResult Index(DrawViewModel dvm)
        {
            if (ModelState.IsValid)
            {
                dvm.Winners = winnersRepository.Winners(dvm.NumberOfEntrants);
                ViewBag.Message = dvm.Winners.Count > 1 ? "The " + dvm.Winners.Count + " lucky winners!" : "The lucky winner!";
                return View(dvm);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
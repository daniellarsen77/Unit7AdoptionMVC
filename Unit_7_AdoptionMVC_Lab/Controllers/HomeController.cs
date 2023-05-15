using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit_7_AdoptionMVC_Lab.Models;

namespace Unit_7_AdoptionMVC_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdoptionDbContext _adoptionDbcontext;
        public HomeController(ILogger<HomeController> logger, AdoptionDbContext adoptionDbcontext)
        {
            _logger = logger;
            _adoptionDbcontext = adoptionDbcontext;
        }

        public IActionResult Index()
        {
            List<string> breeds = _adoptionDbcontext.Animals.Select(a => a.Breed).Distinct().ToList();
            return View(breeds);
        }
        public IActionResult AddAnimal()
        {
            return View();
        }

        // Called when the form is submitted on the add animals form page
        public IActionResult UpdateAnimal(Animal a)
        {
            _adoptionDbcontext.Add(a);
            _adoptionDbcontext.SaveChanges();
            return RedirectToAction("AddAnimal");
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
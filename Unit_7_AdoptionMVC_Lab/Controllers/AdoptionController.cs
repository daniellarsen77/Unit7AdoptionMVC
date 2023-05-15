using Microsoft.AspNetCore.Mvc;
using Unit_7_AdoptionMVC_Lab.Models;

namespace Unit_7_AdoptionMVC_Lab.Controllers
{
    public class AdoptionController : Controller
    {
        private readonly AdoptionDbContext _adoptionDbcontext;
        public AdoptionController(AdoptionDbContext context)
        {
            _adoptionDbcontext = context;
        }
        public IActionResult Index(string SelectedBreed)
        {
            List<Animal> result = _adoptionDbcontext.Animals.Where(a => a.Breed == SelectedBreed).ToList();
            return View(result);
        }

        public IActionResult Adopted(int AnimalId)
        {
            Animal a = _adoptionDbcontext.Animals.FirstOrDefault(x => x.Id == AnimalId);
            _adoptionDbcontext.Animals.Remove(a);
            _adoptionDbcontext.SaveChanges();
            return View(a);
        }
    }
}

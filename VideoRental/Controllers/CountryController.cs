using Microsoft.AspNetCore.Mvc;
using VideoRental.Models;
using VideoRental.Repositories;

namespace VideoRental.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryRepo _countryRepo;

        public CountryController(CountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }
        public IActionResult Index()
        {
            var countries = _countryRepo.GetAll();
            return View(countries);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Country country)
        {
            _countryRepo.Insert(country);
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var country = _countryRepo.GetById(id);
            return View(country);
        }
        [HttpPost]
        public IActionResult Update(Country country)
        {
            _countryRepo.Update(country);
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var country = _countryRepo.GetById(id);
            return View(country);
        }
        [HttpPost]
        public IActionResult Delete(Country country)
        {
            _countryRepo.Delete(country);
            return View();
        }
    }
}

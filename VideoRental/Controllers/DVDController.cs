using Microsoft.AspNetCore.Mvc;
using VideoRental.Models;
using VideoRental.Repositories;

namespace VideoRental.Controllers
{
    public class DVDController : Controller
    {
        private readonly DvdRepo _dvdRepo;

        public DVDController(DvdRepo dvdRepo)
        {
            _dvdRepo = dvdRepo;
        }
        public IActionResult Index()
        {
            var dvds = _dvdRepo.GetAll();
            return View(dvds);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(DVD dvd)
        {
            _dvdRepo.Insert(dvd);
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var dvd = _dvdRepo.GetById(id);
            return View(dvd);
        }
        [HttpPost]
        public IActionResult Update(DVD dvd)
        {
            _dvdRepo.Update(dvd);
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var dvd = _dvdRepo.GetById(id);
            return View(dvd);
        }
        [HttpPost]
        public IActionResult Delete(DVD dvd)
        {
            _dvdRepo.Delete(dvd);
            return View();
        }
    }
}

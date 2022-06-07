using Microsoft.AspNetCore.Mvc;
using VideoRental.Models;
using VideoRental.Repositories;

namespace VideoRental.Controllers
{
    public class ActorController : Controller
    {
        private readonly ActorRepo _actorRepo;

        public ActorController(ActorRepo actorRepo)
        {
            _actorRepo = actorRepo;
        }
        public IActionResult Index()
        {
            var actors = _actorRepo.GetAll();
            return View(actors);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Actor actor)
        {
            _actorRepo.Insert(actor);
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var actor = _actorRepo.GetById(id);
            return View(actor);
        }
        [HttpPost]
        public IActionResult Update(Actor actor)
        {
            _actorRepo.Update(actor);
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = _actorRepo.GetById(id);
            return View(actor);
        }
        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            _actorRepo.Delete(actor);
            return View();
        }
    }
}

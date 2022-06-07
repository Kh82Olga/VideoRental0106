using Microsoft.AspNetCore.Mvc;
using VideoRental.Repositories;

namespace VideoRental.Controllers
{
    public class ActorDvdController : Controller
    {
        private readonly ActorDvdRepo _actorDvdRepo;

        public ActorDvdController(ActorDvdRepo actorDvdRepo)
        {
            _actorDvdRepo = actorDvdRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

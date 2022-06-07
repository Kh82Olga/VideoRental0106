using Microsoft.AspNetCore.Mvc;

namespace VideoRental.Controllers
{
    public class ActorDvdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

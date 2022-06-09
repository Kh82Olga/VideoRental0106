using Microsoft.AspNetCore.Mvc;

namespace VideoRental.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace VideoRental.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

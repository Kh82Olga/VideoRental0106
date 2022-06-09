using Microsoft.AspNetCore.Mvc;
using VideoRental.Models;
using VideoRental.Repositories;

namespace VideoRental.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepo _customerRepo;

        public CustomerController(CustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public IActionResult Index()
        {
            var customers = _customerRepo.GetAll();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Customer customer)
        {
            _customerRepo.Insert(customer);
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var customer = _customerRepo.GetById(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            _customerRepo.Update(customer);
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = _customerRepo.GetById(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            _customerRepo.Delete(customer);
            return View();
        }
    }
}

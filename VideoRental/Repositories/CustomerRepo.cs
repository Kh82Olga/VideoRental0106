using System.Collections.Generic;
using System.Linq;
using VideoRental.Data;
using VideoRental.Interfaces;
using VideoRental.Models;

namespace VideoRental.Repositories
{
    public class CustomerRepo : ICustomer
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int Id)
        {
            return _context.Customers.FirstOrDefault(x => x.CustomerId == Id);
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}

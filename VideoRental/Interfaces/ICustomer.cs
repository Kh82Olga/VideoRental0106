using System.Collections.Generic;
using VideoRental.Models;

namespace VideoRental.Interfaces
{
    public interface ICustomer
    {
        List<Customer> GetAll();
        Customer GetById(int Id);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}

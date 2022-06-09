using System.Collections.Generic;
using VideoRental.Models;

namespace VideoRental.Interfaces
{
    public interface ICountry
    {
        List<Country> GetAll();
        Country GetById(int Id);
        void Insert(Country country);
        void Update(Country country);
        void Delete(Country country);
    }
}

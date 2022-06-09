using System.Collections.Generic;
using System.Linq;
using VideoRental.Data;
using VideoRental.Interfaces;
using VideoRental.Models;

namespace VideoRental.Repositories
{
    public class CountryRepo : ICountry
    {
        private readonly AppDbContext _context;
        public CountryRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(Country country)
        {
            _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        public List<Country> GetAll()
        {
            return _context.Countries.ToList();
        }

        public Country GetById(int Id)
        {
            return _context.Countries.FirstOrDefault(x => x.CountryId == Id);
        }

        public void Insert(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void Update(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VideoRental.Data;
using VideoRental.Interfaces;
using VideoRental.Models;

namespace VideoRental.Repositories
{
    public class DvdRepo : IDvd
    {
        private readonly AppDbContext _context;
        public DvdRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DVD> GetAll() => _context.DVDs
            .Include(e => e.Country)
            .Include(e => e.Actor)
            .Include(e => e.Genre);


        public void Delete(DVD dvd)
        {
            _context.DVDs.Remove(dvd);
            _context.SaveChanges();
        }

        //public List<DVD> GetAll()
        //{
        //    return _context.DVDs.ToList();
        //}

        public DVD GetById(int Id)
        {
            return _context.DVDs.FirstOrDefault(x => x.DvdId == Id);
        }

        public void Insert(DVD dvd)
        {
            _context.DVDs.Add(dvd);
            _context.SaveChanges();
        }

        public void Update(DVD dvd)
        {
            _context.DVDs.Update(dvd);
            _context.SaveChanges();
        }

        
        
    }
}

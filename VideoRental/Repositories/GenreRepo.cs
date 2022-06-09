using System.Collections.Generic;
using System.Linq;
using VideoRental.Data;
using VideoRental.Interfaces;
using VideoRental.Models;

namespace VideoRental.Repositories
{
    public class GenreRepo : IGenre
    {
        private readonly AppDbContext _context;
        public GenreRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(Genre genre)
        {
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }

        public List<Genre> GetAll()
        {
            return _context.Genres.ToList();
        }

        public Genre GetById(int Id)
        {
            return _context.Genres.FirstOrDefault(x => x.GenreKey == Id);
        }

        public void Insert(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void Update(Genre genre)
        {
            _context.Genres.Update(genre);
            _context.SaveChanges();
        }
    }
}

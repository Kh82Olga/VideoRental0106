using System.Collections.Generic;
using VideoRental.Models;

namespace VideoRental.Interfaces
{
    public interface IGenre
    {
        List<Genre> GetAll();
        Genre GetById(int Id);
        void Insert(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);
    }
}

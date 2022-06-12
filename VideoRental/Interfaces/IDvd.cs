using System.Collections.Generic;
using VideoRental.Models;

namespace VideoRental.Interfaces
{
    public interface IDvd
    {
        //List<DVD> GetAll();
        IEnumerable<DVD> GetAll();
        DVD GetById(int Id);
        void Insert(DVD dvd);
        void Update(DVD dvd);
        void Delete(DVD dvd);
    }
}

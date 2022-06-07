using System.Collections.Generic;
using VideoRental.Models;

namespace VideoRental.Interfaces
{
    public interface IActor
    {
        List<Actor> GetAll();
        Actor GetById(int Id);
        void Insert(Actor actor);
        void Update(Actor actor);
        void Delete(Actor actor);
    }
}

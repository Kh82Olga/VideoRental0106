using System.Collections.Generic;
using System.Linq;
using VideoRental.Data;
using VideoRental.Interfaces;
using VideoRental.Models;

namespace VideoRental.Repositories
{
    public class ActorRepo : IActor
    {
        private readonly AppDbContext _context;
        public ActorRepo(AppDbContext context)
        {
                _context = context;
        }
        public void Delete(Actor actor)
        {
            _context.Actors.Remove(actor);
        }

        public List<Actor> GetAll()
        {
            return _context.Actors.ToList();
        }

        public Actor GetById(int Id)
        {
            return _context.Actors.FirstOrDefault(x => x.ActorId == Id);
        }

        public void Insert(Actor actor)
        {
            _context.Actors.Add(actor);
        }

        public void Update(Actor actor)
        {
           _context.Actors.Update(actor);
        }
    }
}

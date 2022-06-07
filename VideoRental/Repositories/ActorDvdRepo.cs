using VideoRental.Data;
using VideoRental.Interfaces;

namespace VideoRental.Repositories
{
    public class ActorDvdRepo : IActorDvd
    {
        private readonly AppDbContext _context;
        private IActor _actorRepo;
        private IDvd _dvdRepo;
        public ActorDvdRepo(AppDbContext context)
        {
            _context = context;
        }
        public IActor Actor
        {
            get { return _actorRepo = _actorRepo ?? new ActorRepo(_context); }
        }


        public IDvd Dvd
        {
            get { return _dvdRepo = _dvdRepo ?? new DvdRepo(_context); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

using System.Collections.Generic;

namespace VideoRental.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<ActorDvd> ActorDvds { get; set; }
    }
}

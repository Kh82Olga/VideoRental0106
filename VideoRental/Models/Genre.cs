using System.Collections.Generic;

namespace VideoRental.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public int AgeLimit { get; set; }
        public virtual ICollection<GenreDvd> GenreDvds { get; set; }
    }
}

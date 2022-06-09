using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoRental.Models
{
    public class Genre
    {
        [Key]
        [Column("Id")]
        public int GenreKey { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public int AgeLimit { get; set; }
        public virtual ICollection<DVD> DVDs { get; set; }
    }
}

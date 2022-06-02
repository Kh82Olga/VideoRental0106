using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoRental.Models
{
    public class DVD
    {
        public int DvdId { get; set; }
        public string MovieName { get; set; }
        public string ReleaseYear { get; set; }
        public string Language { get; set; }
        public bool Available { get; set; }
        //public int CustomerId { get; set; }
        //[ForeignKey("CustomerId")]
        //public virtual Customer Customer { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public virtual ICollection<ActorDvd> ActorDvds { get; set; }
        public virtual ICollection<GenreDvd> GenreDvds { get; set; }

    }
}

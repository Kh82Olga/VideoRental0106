using System;

namespace VideoRental.Models
{
    public class DVD
    {
        public int DvdId { get; set; }
        public string MovieName { get; set; }
        public string ReleaseYear { get; set; }
        public bool Available { get; set; }
    }
}

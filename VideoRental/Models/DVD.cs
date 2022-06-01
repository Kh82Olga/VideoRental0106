using System;

namespace VideoRental.Models
{
    public class DVD
    {
        public int DvdId { get; set; }
        public string MovieName { get; set; }
        public DateTime Release { get; set; }
        public bool Available { get; set; }
    }
}

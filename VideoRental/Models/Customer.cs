using System;
using System.Collections.Generic;

namespace VideoRental.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } 
        public string CustomerName { get; set; }
        public int Age { get; set; }
        //public virtual ICollection<DVD> DVDs { get; set; }
    }
}

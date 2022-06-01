using System;

namespace VideoRental.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } 
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Returned { get; set; }
    }
}

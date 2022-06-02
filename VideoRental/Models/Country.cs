using System.Collections.Generic;

namespace VideoRental.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<DVD> DVDs { get; set; }
    }
}

namespace VideoRental.Models
{
    public class GenreDvd
    {
        public int GenreId { get; set; }
        public int DvdId { get; set; }
        public Genre Genre { get; set; }
        public DVD DVD { get; set; }
    }
}

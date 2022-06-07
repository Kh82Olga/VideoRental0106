namespace VideoRental.Models
{
    public class ActorDvd
    {
        public int ActorId { get; set; }
        public int DvdId { get; set; } 
        public Actor Actor { get; set; }
        public DVD DVD { get; set; }
    }
}

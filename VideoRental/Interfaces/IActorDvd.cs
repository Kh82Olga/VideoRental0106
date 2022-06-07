namespace VideoRental.Interfaces
{
    public interface IActorDvd
    {
        IActor Actor { get; }
        IDvd Dvd { get; }
        void Save();
    }
}

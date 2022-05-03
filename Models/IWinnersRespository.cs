namespace PromotigoMVC.Models
{
    public interface IWinnersRepository
    {
        List<Entrant> Winners(int numWinners);
    }
}

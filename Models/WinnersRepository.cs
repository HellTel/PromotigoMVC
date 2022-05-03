namespace PromotigoMVC.Models

{
    using data;
    using Microsoft.EntityFrameworkCore;

    public class WinnersRepository : IWinnersRepository
    {
        private readonly PromotigoMVCDBContext db;
        public WinnersRepository(PromotigoMVCDBContext dbRep)
        {
            db = dbRep;
        }
        public List<Entrant> Winners(int numWinners)
        {
            int numEntrants = db.Entrant.Count();
            // check to make sure there aren't more winners than entrants. Unlikely in the real world, but possible in the test environment
            //List<Entrant> winners = (List<Entrant>)db.Entrants.OrderBy(x => Guid.NewGuid()).Take(numWinners).ToList(); // OK if you don't mind repeated results
            Random random = new Random();
            int skip = random.Next(numEntrants); // could be a problem if it skips too far, it may return fewer winners than requested
            List<Entrant> winners = (List<Entrant>)db.Entrant.Skip(skip).Take(numWinners).ToList();
            // so check if we have enough winners, if not, grab the extras
            while (winners.Count() < numWinners)
            {
                skip = random.Next(numEntrants);
                List<Entrant> extras = (List<Entrant>)db.Entrant.Skip(skip).Take(numWinners - winners.Count()).ToList();
                foreach (Entrant e in extras)
                {
                    // check to avoid repeats though
                    if (!winners.Contains(e))
                    {
                        winners.Add(e);
                    }
                }
            }
            return winners;
        }
    }

}

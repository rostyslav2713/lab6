using System.Data.Entity;

namespace lab6.Models
{
    public class Match_dbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            db.Matches.Add(new Match { matchId = 1, matchFirstTeam = "Barcelona", matchSecondTeam = "Real Madrid", matchTicketPrice = 399 });
            db.Matches.Add(new Match { matchId = 2, matchFirstTeam = "Real Madrid", matchSecondTeam = "Real Madrid", matchTicketPrice = 299 });
            db.Matches.Add(new Match { matchId = 3, matchFirstTeam = "Barcelona", matchSecondTeam = "Barcelona", matchTicketPrice = 199 });
           
            base.Seed(db);
        }
    }
}
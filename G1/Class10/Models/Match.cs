using System;

namespace Models
{
    public class Match
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }
        public MatchStatus Status { get; set; }

        public Match(Team team1, Team team2)
        {
            Team1 = team1;
            Team2 = team2;
            Status = MatchStatus.Pending;
        }

        public void SimulateMatch()
        {
            Random rnd = new Random();
            Team1Goals = rnd.Next(0, 5);
            Team2Goals = rnd.Next(0, 5);
            Status = MatchStatus.Finished;
        }
    }
}

using System.Collections.Generic;

namespace Models
{
    public class Team
    {
        public string Name { get; set; }
        public Trainer Trainer { get; set; }
        public List<Player> Players { get; set; }
        public int Points { get; set; } = 0;
        public int NumberOfWins { get; set; } = 0;
        public int NumberOfDraws { get; set; } = 0;
        public int NumberOfLoses { get; set; } = 0;
        public int NumberOfScoredGoals { get; set; } = 0;
        public int NumberOfConcededGoals { get; set; } = 0;
        public int GamePlayed => NumberOfWins + NumberOfDraws + NumberOfLoses;


        public Team(string name, Trainer trainer, List<Player> players)
        {
            Name = name;
            Trainer = trainer;
            Players = players;
        }

        public Team(string name, Trainer trainer)
        {
            Name = name;
            Trainer = trainer;
            Players = new List<Player>();
        }
    }
}

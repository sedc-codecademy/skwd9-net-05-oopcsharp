using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class League
    {
        public string Name { get; set; }
        public string Season { get; set; }
        //Liverpool 0+3
        //Chelsea 0
        //Arsenal 0
        public List<Team> Teams { get; set; } = new List<Team>();
        //Liverpool vs Chelsea 2 - 1
        //Liverpool vs Arsenal 0 - 0
        public List<Match> Matches { get; set; } = new List<Match>();

        public League(string name, string season)
        {
            Name = name;
            Season = season;
        }

        public void CreateMatches()
        {
            for (int i = 0; i < Teams.Count; i++)
            {
                for (int j = 0; j < Teams.Count; j++)
                {
                    if (Teams[i].Name == Teams[j].Name)
                    {
                        continue;
                    }

                    Match match = new Match(Teams[i], Teams[j]);
                    Matches.Add(match);
                }
            }

            //foreach (var team1 in Teams)
            //{
            //    foreach (var team2 in Teams)
            //    {
            //        if (team1.Name == team2.Name)
            //        {
            //            continue;
            //        }

            //        Match match = new Match(team1, team2);
            //        Matches.Add(match);
            //    }
            //}
        }

        public void SimulateAllMatches()
        {
            foreach (var match in Matches)
            {
                match.SimulateMatch();

                if (match.Team1Goals > match.Team2Goals)
                {
                    //winner first
                    Team winner = Teams.First(x => x.Name == match.Team1.Name);
                    Team looser = Teams.First(x => x.Name == match.Team2.Name);
                    winner.Points += 3;
                    winner.NumberOfWins++;
                    looser.NumberOfLoses++;
                    winner.NumberOfScoredGoals += match.Team1Goals;
                    winner.NumberOfConcededGoals += match.Team2Goals;

                    looser.NumberOfScoredGoals += match.Team2Goals;
                    looser.NumberOfConcededGoals += match.Team1Goals;
                } 
                else if (match.Team1Goals < match.Team2Goals)
                {
                    //winner second
                    Team winner = Teams.First(x => x.Name == match.Team2.Name);
                    Team looser = Teams.First(x => x.Name == match.Team1.Name);
                    winner.Points += 3;
                    winner.NumberOfWins++;
                    looser.NumberOfLoses++;
                    
                    winner.NumberOfScoredGoals += match.Team2Goals;
                    winner.NumberOfConcededGoals += match.Team1Goals;

                    looser.NumberOfScoredGoals += match.Team1Goals;
                    looser.NumberOfConcededGoals += match.Team2Goals;
                }
                else
                {
                    //draw
                    Team team1 = Teams.First(x => x.Name == match.Team1.Name);
                    Team team2 = Teams.First(x => x.Name == match.Team2.Name);
                    team1.Points += 1;
                    team2.Points += 1;
                    team1.NumberOfDraws++;
                    team2.NumberOfDraws++;
                    
                    team1.NumberOfScoredGoals += match.Team1Goals;
                    team1.NumberOfConcededGoals += match.Team2Goals;

                    team2.NumberOfScoredGoals += match.Team2Goals;
                    team2.NumberOfConcededGoals += match.Team1Goals;
                }
            }
        }

        public string GetInfo()
        {
            return $"{Name} {Season}\n";
        }

        public string GetMatches()
        {
            string matches = "Matches:\n";

            foreach (Match match in Matches)
            {
                //matches += $"{match.Team1.Name,20} | {match.Team2.Name,20} | {match.Team1Goals,5} | {match.Team2Goals,5}\n";
                //matches += string.Format("{0,20} | {1,20} | {2,5} | {3,5} |\n", match.Team1.Name, match.Team2.Name, match.Team1Goals, match.Team2Goals);
                string team1Score = match.Status == MatchStatus.Finished ? match.Team1Goals.ToString() : "-";
                string team2Score = match.Status == MatchStatus.Finished ? match.Team2Goals.ToString() : "-";
                matches += $"{match.Team1.Name,20} vs {match.Team2.Name,-20} | {team1Score,3} : {team2Score,-3}\n";
            }

            return matches;
        }

        public string GetTable()
        {
            List<Team> orderTable = Teams.OrderByDescending(x => x.Points).ToList();

            string table = "Table:\n";
            table += $"{"No.",4} {"Name",-20} | {"GP",-5} | {"Wins",-5} | {"Draws",-5} | {"Loses",-5} | {"SG",5}:{"CG",-5} | Points\n";
            //table += string.Join("\n", orderTable.Select(x => $"{x.Name,20} | {x.Points}"));

            for (int i = 0; i < orderTable.Count; i++)
            {
                table += $"{i+1,3}. {orderTable[i].Name,-20} | {orderTable[i].GamePlayed,-5} | {orderTable[i].NumberOfWins,-5} | {orderTable[i].NumberOfDraws,-5} | {orderTable[i].NumberOfLoses,-5} | {orderTable[i].NumberOfScoredGoals,5}:{orderTable[i].NumberOfConcededGoals,-5} | {orderTable[i].Points}\n";
            }

            return table;
        }
    }
}

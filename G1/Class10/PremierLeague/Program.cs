using System;
using Models;

namespace PremierLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            League league = new League("Premier League", "2020/2021");

            #region Liverpool

            Trainer liverpoolTrainer = new Trainer("Jurgen", "Klop", 50, 15);
            Team liverpool = new Team("Liverpool", liverpoolTrainer);

            Player liverpoolGk = new Player("Alisson", "Beker", 28, Position.Gk);
            Player liverpoolDef = new Player("Virgil", "Van Dyk", 26, Position.Def);
            Player liverpoolMid = new Player("James", "Milner", 33, Position.Mid);
            Player liverpoolFwd = new Player("Mo", "Salah", 28, Position.Fwd);

            liverpool.Players.Add(liverpoolGk);
            liverpool.Players.Add(liverpoolDef);
            liverpool.Players.Add(liverpoolMid);
            liverpool.Players.Add(liverpoolFwd);

            league.Teams.Add(liverpool);

            #endregion

            #region Chelsea

            Trainer chelseaTrainer = new Trainer("Tomas", "Tuhel", 48, 10);
            Team chelsea = new Team("Chelsea", chelseaTrainer);

            Player chelseaGk = new Player("Forlan", "Mendy", 20, Position.Gk);
            Player chelseaDef = new Player("Zuma", "Kurt", 22, Position.Def);
            Player chelseaMid = new Player("Jason", "Mount", 22, Position.Mid);
            Player chelseaFwd = new Player("Olivie", "Giroud", 28, Position.Fwd);

            chelsea.Players.Add(chelseaGk);
            chelsea.Players.Add(chelseaDef);
            chelsea.Players.Add(chelseaMid);
            chelsea.Players.Add(chelseaFwd);

            league.Teams.Add(chelsea);

            #endregion

            #region ManCity

            Trainer cityTrainer = new Trainer("Pep", "Gvardiola", 55, 20);
            Team city = new Team("Manchester City", cityTrainer);

            Player cityGk = new Player("Ederson", "Moraes", 25, Position.Gk);
            Player cityDef = new Player("John", "Stones", 22, Position.Def);
            Player cityMid = new Player("Kevin", "De Bryne", 24, Position.Mid);
            Player cityFwd = new Player("Kun", "Augero", 32, Position.Fwd);

            city.Players.Add(cityGk);
            city.Players.Add(cityDef);
            city.Players.Add(cityMid);
            city.Players.Add(cityFwd);

            league.Teams.Add(city);

            #endregion

            #region ManUtd

            Trainer manUtdTrainer = new Trainer("Ole", "Solsker", 55, 20);
            Team manUtd = new Team("Manchester United", manUtdTrainer);

            Player manUtdGk = new Player("David", "De Gea", 30, Position.Gk);
            Player manUtdDef = new Player("Herry", "Magvier", 28, Position.Def);
            Player manUtdMid = new Player("Bruno", "Fernandes", 24, Position.Mid);
            Player manUtdFwd = new Player("Markus", "Rashvord", 22, Position.Fwd);

            manUtd.Players.Add(manUtdGk);
            manUtd.Players.Add(manUtdDef);
            manUtd.Players.Add(manUtdMid);
            manUtd.Players.Add(manUtdFwd);

            league.Teams.Add(manUtd);

            #endregion

            #region Leicester

            Trainer leicesterTrainer = new Trainer("Brandon", "Rodzers", 55, 20);
            Team leicester = new Team("Leicester", leicesterTrainer);

            Player leicesterGk = new Player("Kasper", "Shmajhel", 30, Position.Gk);
            Player leicesterDef = new Player("Jony", "Evans", 25, Position.Def);
            Player leicesterMid = new Player("Juri", "Tilemans", 26, Position.Mid);
            Player leicesterFwd = new Player("Jammy", "Vardy", 33, Position.Fwd);

            leicester.Players.Add(leicesterGk);
            leicester.Players.Add(leicesterDef);
            leicester.Players.Add(leicesterMid);
            leicester.Players.Add(leicesterFwd);

            league.Teams.Add(leicester);

            #endregion

            league.CreateMatches();

            Console.Write(league.GetInfo());
            Console.Write(league.GetMatches());
            Console.WriteLine(league.GetTable());

            Console.WriteLine("============Odds===============");
            GenerateOdds(league);

            Console.WriteLine("========Press a key to start simulation");
            Console.ReadLine();
            Console.WriteLine("===============Lets Play==================");
            league.SimulateAllMatches();
            Console.Write(league.GetMatches());
            Console.WriteLine(league.GetTable());
        }

        static void GenerateOdds(League league)
        {
            Random rnd = new Random();
            foreach (Team team in league.Teams)
            {
                int rndInt = rnd.Next(3, 15);
                double rndDouble = rnd.NextDouble();

                Console.WriteLine($"{team.Name} ({rndInt + rndDouble:0.##})");
            }
        }
    }
}

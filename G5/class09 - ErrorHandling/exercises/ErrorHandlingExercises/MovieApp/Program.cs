using MovieApp.Entities;
using MovieApp.Enums;
using System;
using System.Collections.Generic;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //set 1
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 3);
            Movie movie3 = new Movie("Saw", Genre.Horror, 1);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 2);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 1);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 3);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 2);

            //set 2
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 2);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 3);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 1);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 2);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 1);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 2);

            //movie sets
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
        }
    }
}

using Exercises.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
                Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
                Movie movie3 = new Movie("Saw", Genre.Horror, 4);
                Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
                Movie movie5 = new Movie("Rambo", Genre.Action, 4);
                Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
                Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
                Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
                Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
                Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
                Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
                Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
                Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
                Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
                Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
                Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
                Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
                Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
                Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
                Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);

                Cinema cinema1 = new Cinema(
                    "Kino1",
                    new List<int>() { 1, 2, 3, 4 },
                    new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 });

                Cinema cinema2 = new Cinema(
                    "Kino2",
                    new List<int>() { 1, 2, 3, 4, 5, 6, 7 },
                    new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 });
                Cinema currentCinema = null;
            
                Console.WriteLine("Please choose cinema");
                Console.WriteLine($"1. {cinema1.Name}");
                Console.WriteLine($"2. {cinema2.Name}");
                int cinema = int.Parse(Console.ReadLine());
                if (cinema == 1)
                {
                    currentCinema = cinema1;
                }
                else if (cinema == 2)
                {
                    currentCinema = cinema2;
                }
                else
                {
                    throw new Exception("You must enter 1 or 2 for cinema");
                }


                Console.WriteLine("Choose movies:");
                Console.WriteLine($"1. All");
                Console.WriteLine($"2. By Genre");
                int movieOption = int.Parse(Console.ReadLine());
                if (movieOption == 1)
                {
                    foreach (Movie movie in currentCinema.ListOfMovies)
                    {
                        Console.WriteLine(movie.Title);
                    }
                    Console.WriteLine("Choose one of the above movies:");
                    string chosenMovie = Console.ReadLine();
                    currentCinema.WatchMovie(currentCinema.ListOfMovies
                        .FirstOrDefault(x => x.Title.ToLower() == chosenMovie.ToLower()));
                }
                else if (movieOption == 2)
                {
                    Console.WriteLine("Enter genre:");
                    Console.WriteLine("1) Comedy");
                    Console.WriteLine("2) Horror");
                    Console.WriteLine("3) Action");
                    Console.WriteLine("4) Drama");
                    Console.WriteLine("5) SciFi");
                    int inputGenre = int.Parse(Console.ReadLine());
                    Genre currentGenre;
                    switch (inputGenre)
                    {
                        case 1:
                            currentGenre = Genre.Comedy;
                            break;
                        case 2:
                            currentGenre = Genre.Horror;
                            break;
                        case 3:
                            currentGenre = Genre.Action;
                            break;
                        case 4:
                            currentGenre = Genre.Drama;
                            break;
                        case 5:
                            currentGenre = Genre.SciFi;
                            break;
                        default:
                            throw new Exception("The genre input was not correct! Sorry, you broke it!");
                    }

                    Console.WriteLine("Choose a movie to watch: ( Write the name )");
                    List<Movie> personMoviesByGenre = currentCinema.ListOfMovies.Where(movie => movie.Genre == currentGenre).ToList();
                    foreach (var movie in personMoviesByGenre)
                    {
                        Console.WriteLine(movie.Title);
                    }
                    string inputMovie = Console.ReadLine();
                    // Another way to get first element from list
                    Movie userChosenMovie = personMoviesByGenre.Where(movie => movie.Title.ToLower() == inputMovie.ToLower()).FirstOrDefault();
                    currentCinema.WatchMovie(userChosenMovie);
                }
                else
                {
                    throw new Exception("You must choose valid option for movies");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Incorrect input");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Movie does not exist");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}

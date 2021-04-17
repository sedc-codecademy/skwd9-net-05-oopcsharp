using System;
using System.Collections.Generic;
using System.Threading;
using Exercise01_Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cinema cinema = new Cinema("Cineplexx", 8);

                Movie movie1 = new Movie("Treto poluvreme", Genre.Drama, 4);
                Movie movie2 = new Movie("Medena zemja", Genre.Drama, 5);
                Movie movie3 = new Movie("Tetoviranje", Genre.Drama, 5);
                Movie movie4 = new Movie("Balkankan", Genre.Comedy, 4);
                Movie movie5 = new Movie("Coming to America", Genre.Comedy, 4);
                //Movie movie6 = new Movie("Prasina", Genre.Drama, 8);

                cinema.Movies.AddRange(new List<Movie> {movie1, movie2, movie3, movie4, movie5});

                Console.WriteLine(cinema.MoviePlaying(movie1));
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"NullReferenceException: {ex.Message}");
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ArgumentOutOfRangeException: {ex.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}

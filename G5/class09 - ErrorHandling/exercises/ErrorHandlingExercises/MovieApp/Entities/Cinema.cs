using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public void WatchMovie(Movie movie) 
        {
            Console.WriteLine($"Watching {movie.Title}");
        }

        public Cinema()
        {
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();
        }

    }
}

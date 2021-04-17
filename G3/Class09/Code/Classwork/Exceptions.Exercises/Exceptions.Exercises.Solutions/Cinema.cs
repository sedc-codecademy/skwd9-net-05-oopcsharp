using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Exercises.Solutions
{
    public class Cinema
    {
        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            this.Name = name;
            this.Halls = halls;
            this.Movies = movies;
        }
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"The movie {movie.Title} is playing....");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01_Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, int halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public Cinema(string name, int halls)
        {
            Name = name;
            Halls = halls;
            Movies = new List<Movie>();
        }

        public string MoviePlaying(Movie movie)
        {
            //if (!Movies.Any(x => x.Title == movie.Title))
            if (Movies.All(x => x.Title != movie.Title))
            {
                throw new Exception($"The movie {movie.Title} is not in the cinema  {Name}");
            }

            return $"Playing {movie.Title}";
        }
    }
}

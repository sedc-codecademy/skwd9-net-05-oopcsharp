using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise02_Models
{
    public class Person
    {
        //public int Id => (new Random()).Next(0, Int32.MaxValue);
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; } = new List<Song>();

        public Person(string firstName, string lastName, int age, GenreEnum favoriteMusicType)
        {
            Random rnd = new Random();

            Id = rnd.Next(0, int.MaxValue);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            //Songs = new List<Song>();
        }

        public Person(string firstName, string lastName, int age, GenreEnum favoriteMusicType, List<Song> favoriteSongs)
        {
            Random rnd = new Random();

            Id = rnd.Next(0, int.MaxValue);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs;
        }

        public Person()
        {
            Random rnd = new Random();

            Id = rnd.Next(0, int.MaxValue);
            //Songs = new List<Song>();
        }

        public string GetFavSongs()
        {
            //string titles = "";

            //foreach (var song in FavoriteSongs)
            //{
            //    titles += song.Title + "; ";
            //}

            //if (FavoriteSongs.Count == 0)
            //{
            //    titles = "This person hates music";
            //}

            //return titles;

            List<string> favoriteSongTitles = FavoriteSongs.Select(x => x.Title).ToList();
            //string titles = string.Join("; ", favoriteSongTitles);
            //return titles;

            return FavoriteSongs.Count == 0 
                ? "This person hates music" 
                : string.Join("; ", FavoriteSongs.Select(x => $"{x.Title} {x.Genre}"));
        }
    }
}

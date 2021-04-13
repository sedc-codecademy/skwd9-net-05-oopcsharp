using ExerciseEntities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseEntities.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favoriteMusicType)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
        }

        public void GetFavSongs() 
        {
            if (FavoriteSongs.Count > 0)
            {
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine($"{song.Title} - {song.Genre} - {song.Length}");
                }
            }
            else 
            {
                Console.WriteLine($"{FirstName} {LastName} hates music!");
            }
        }

    }
}

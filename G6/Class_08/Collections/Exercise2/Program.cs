using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 22,
                Id = 1
            };
            person.FavouriteSongs.Add(new Song()
            {
                Genre = Genre.Rock,
                Length = 3.0,
                Title = "It's my life"
            });
            person.FavouriteSongs.Add(new Song()
            {
                Genre = Genre.Hip_hop,
                Length = 2,
                Title = "Remember the name"
            });
            person.GetFavSongs();
            Console.ReadLine();
        }
    }
}

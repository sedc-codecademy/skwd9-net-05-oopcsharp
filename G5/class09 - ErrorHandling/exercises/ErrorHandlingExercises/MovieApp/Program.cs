using MovieApp.Entities;
using MovieApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***PLEASE DEBUG THE WHOLE APPLICATION AND GO LINE BY LINE TO UNDERSTAND WHAT IS HAPPENING***

            // Here we are creating a dummy data for our application (this data can come form many sources)
            List<Cinema> cinemas = GenerateMovieAppData();

            // Here we are calling the StartMovieApp() method that taks a List of cinema as a input parameter and will initiate the console UI 
            StartMovieApp(cinemas);

            Console.ReadLine();
        }

        public static void StartMovieApp(List<Cinema> cinemas) 
        {
            // Here, we are asking the user to chose between all cinemas in the list that is the input paramter of ths method
            Console.WriteLine("Chose a cinema: ");
            // Here we are listing all the cinema names and displaying in the console
            for (int i = 0; i < cinemas.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {cinemas[i].Name}");
            }

            // Here, we are letting the user choose which cinema, he wants to see the movies that are part of
            int cinemaInput = int.Parse(Console.ReadLine());
            Cinema currnetCinema = cinemas[cinemaInput - 1];

            Console.WriteLine($"Movies that plays now in {currnetCinema.Name}: ");
            Console.WriteLine("1) Show all movies");
            Console.WriteLine("2) Show by genre");
            int moviesInput = int.Parse(Console.ReadLine());

            if (moviesInput == 1)
            {
                // if the user chooses the option to see all the movies that are part of the chosen cinema, this method below will be called
                ListAllMoviesForACinema(currnetCinema);
            }
            else if (moviesInput == 2) 
            {
                // if the user chooses the option to see movies that are filtered by some Genre, this method below will be called
                ListAllGenersForACinema(currnetCinema);

            }
        }
        public static void ListAllMoviesForACinema(Cinema currnetCinema)
        {
            // Here, we are displaying in the console all the movies by title that are part of the chosen cinema
            Console.WriteLine("Choose a move to watch: (Write a name)");
            currnetCinema.ListOfMovies.ForEach(movie => Console.WriteLine(movie.Title));

            // Here, we are letting the user to chose what movie he wants to see
            ChooseAMovie(currnetCinema, currnetCinema.ListOfMovies);
        }

        public static void ListAllGenersForACinema(Cinema currnetCinema) 
        {
            // Here, we are letting the user to choose witch genre of movie he would like to see
            Console.WriteLine("Enter genre:");
            Console.WriteLine("1) Comedy");
            Console.WriteLine("2) Horror");
            Console.WriteLine("3) Action");
            Console.WriteLine("4) Drama");
            Console.WriteLine("5) SciFi");

            int genreInput = int.Parse(Console.ReadLine());
            Genre currnetGenre = new Genre();

            switch (genreInput)
            {
                case 1:
                    currnetGenre = Genre.Comedy;
                    break;
                case 2:
                    currnetGenre = Genre.Horror;
                    break;
                case 3:
                    currnetGenre = Genre.Action;
                    break;
                case 4:
                    currnetGenre = Genre.Drama;
                    break;
                case 5:
                    currnetGenre = Genre.SciFi;
                    break;
                default:
                    // throw new exception if other number is chosen
                    break;
            }

            // After the user chosses the genre, we are calling the ListAllMoviesByCurrentGenre() method that will dispaly all the movies filtered by the chosen genre
            ListAllMoviesByCurrentGenre(currnetCinema, currnetGenre);
        }

        public static void ListAllMoviesByCurrentGenre(Cinema currnetCinema, Genre gnereInput) 
        {
            Console.WriteLine("Choose a move to watch: (Write a name)");
            List<Movie> filteredMoviesByInputGenre = currnetCinema.ListOfMovies.Where(movie => movie.Genre == gnereInput).ToList();
            filteredMoviesByInputGenre.ForEach(movie => Console.WriteLine(movie.Title));


            ChooseAMovie(currnetCinema, filteredMoviesByInputGenre);
        }

        public static void ChooseAMovie(Cinema currnetCinema, List<Movie> movies)
        {
            // After the moves are listed, the user will be asked what movie he wants to play and then we will call the WatchMovie method that is part of a each cinema entity in this applciation
            string chosenMovie = Console.ReadLine();
            Movie movie = movies.Where(movie => movie.Title.ToLower() == chosenMovie.ToLower()).FirstOrDefault();
            currnetCinema.WatchMovie(movie);
        }




        public static List<Cinema> GenerateMovieAppData() 
        {
            //Here we are instantinting an object from a class Movie, that we define in the folder Entites in our code structure
            
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

            //Here we are instantiating a new List of Movies and adding the new moive objects created from above and puiting them in the new list

            //movie sets
            List<Movie> movieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            List<Movie> movieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            // Here we are instantinting an object from a class Cinema and directly filling the date for each new object
            Cinema cinema1 = new Cinema()
            {
                Name = "Cineplexx",
                Halls = new List<int>() { 1, 2, 3, 4, 5 },
                ListOfMovies = movieSet1
            };

            Cinema cinema2 = new Cinema()
            {
                Name = "Milenium",
                Halls = new List<int>() { 1, 2 },
                ListOfMovies = movieSet2
            };

            // Here we are instantiating a new List of Cinemas and ading the newly cretaed cinemas abouve in the list
            List<Cinema> cinemas = new List<Cinema>() { cinema1, cinema2 };

            // Here we are return the cinemas variable that is of a type List of Cinema
            return cinemas;
        }  
    }
}

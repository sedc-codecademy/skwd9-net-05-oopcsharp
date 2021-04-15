using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Exercises.Solutions
{
    public class Movie
    {
        public Movie(string title, Genre movieGenre, short rating)
        {
            if(rating >= 1 && rating <= 5)
            {
                this.Rating = rating;
            }
            else
            {
                try
                {
                    throw new Exception("The rating you added was not valid");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            this.Title = title;
            this.MovieGenre = movieGenre;
            this.TicketPrice = Rating * 5;
        }
        public string  Title { get; set; }
        public Genre MovieGenre { get; set; }
        public short Rating { get; set; }
        public double TicketPrice { get; set; }
    }
}

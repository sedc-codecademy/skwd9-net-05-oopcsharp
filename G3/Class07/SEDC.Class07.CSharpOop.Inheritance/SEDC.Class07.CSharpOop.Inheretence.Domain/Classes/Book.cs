using System;

namespace SEDC.Class07.CSharpOop.Inheretence.Domain.Classes
{
    //Base class
    public class Book
    {
        public Book()
        {

        }

        public Book(string title, string author, BookGenre genre, double price,DateTime publishedDate, int numberOfPages)
        {
            this.BookId = SetBookId();
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Price = price;
            this.PublishedDate = publishedDate;
            this.NumberOfPages = numberOfPages;
        }
        private int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenre Genre { get; set; }
        public double Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public int NumberOfPages { get; set; }

        private int SetBookId()
        {
            return new Random().Next(1, 100);
        }
        //With virtual we say we might need some specific logic for this method in a child class
        public virtual string GetBookInfo()
        {
            return $"The book {Title} with book id {BookId} from author {Author} is published on {PublishedDate}";
        }
    }
}

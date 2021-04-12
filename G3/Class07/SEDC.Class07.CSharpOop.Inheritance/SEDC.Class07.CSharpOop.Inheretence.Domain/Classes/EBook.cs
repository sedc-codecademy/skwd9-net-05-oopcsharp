using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.CSharpOop.Inheretence.Domain.Classes
{
    //EBook is inheriting from book. Book is a base class, EBook is a derived class
    public class EBook : Book
    {
        //Default empty constructor
        public EBook()
        {

        }
        //Constructor that inherits from the base Book constructor and adds memorySize
        public EBook(string title,string author, BookGenre genre, double price, DateTime publishedDate, int pages, int memorySize) : base(title,author,genre,price,publishedDate, pages)
        {
            this.MemorySize = memorySize;
        }
        public int MemorySize { get; set; }

        //Specific method for EBook
        public string GetDownloadLink()
        {
            return $"https://bookstore.com/downloads/";
        }
        //Method that we inherit from Book but change the implementation
        public override string GetBookInfo()
        {
            return $"Zdravo ova e memorijata {MemorySize} MB";
        }
    }
}

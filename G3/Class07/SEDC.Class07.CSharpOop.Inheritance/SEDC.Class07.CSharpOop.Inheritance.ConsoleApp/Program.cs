using System;
using SEDC.Class07.CSharpOop.Inheretence.Domain.Classes;
using SEDC.Class07.CSharpOop.Inheritance.Services.Serices;

namespace SEDC.Class07.CSharpOop.Inheritance.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book newBook = new Book();
            //User damjan = new User();
            //BookService bookService = new BookService();
            //EBook electronicBook = new EBook();
            //We are creating regular book
            Book bookWithId = new Book("title", "author", BookGenre.Adventure,10.5, DateTime.Now,200);
            //Calling the regular book GetBookInfo method
            string regularBookInfo = bookWithId.GetBookInfo();
            Console.WriteLine(regularBookInfo);
            //Creating e-book
            EBook electronicBook = new EBook()
            {
                Author = "electronic book author",
                Genre = BookGenre.Comedy,
                NumberOfPages = 300,
                Title = "Some e book",
                Price = 17.3,
                PublishedDate = new DateTime(1996, 04, 03),
                MemorySize = 50
            };
            //Calling the overriden GetBookInfo method
            string electornicBookInfo = electronicBook.GetBookInfo();
            Console.WriteLine(electornicBookInfo);
            EBook eBook2 = new EBook("Kindle book", "Stephen King", BookGenre.Adventure, 13.7, new DateTime(1994, 10, 11), 400, 80);
            string ebook2Info = eBook2.GetBookInfo();
            Console.WriteLine(ebook2Info);
            KindleEbook kindleEBookObj = new KindleEbook();
            
            Console.ReadLine();
        }
    }
}

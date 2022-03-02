using System;
using LibraryHW.Models;

namespace LibraryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "Rolling", 780, "Adventure");
            Book book1 = new Book("Hungry Games", "Onur", 500, "Horror");
            Book book2= new Book("The Great Gatsby", "Tural", 1200, "Mystchic");
            Book book3 = new Book("Onur Potter", "NoName", 445, "Sonnen");
            Book book4 = new Book("Tural Potter", "Ismayil", 643, "Never Land");
            //Book book5 = new Book("Onur Potter", "Lox", 2346, "Detective");

            Library library = new Library();
            library.Add(book);
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            //library.Add(book5);

            library.ShowInfo("sadasd");

            foreach (var libraryBook in library.Books)
            {
                Console.WriteLine(libraryBook);
            }


        }
    }
}

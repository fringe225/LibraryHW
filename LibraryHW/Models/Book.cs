using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHW.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }

        public Book(string name,string author,int pageCount,string genre)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            Genre = genre;

        }

        public override string ToString()
        {
            return $"Name:{Name}\n" +
                   $"Author: {Author}\n" +
                   $"PageCount: {PageCount}\n" +
                   $"Genre: {Genre}\n";
        }
    }
}

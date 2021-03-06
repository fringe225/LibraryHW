using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using LibraryHW.Exceptions;
using LibraryHW.Interfaces;

namespace LibraryHW.Models
{
    internal class Library:ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public Library()
        {
            _books = new List<Book>();
        }
        public void Add(Book book)
        {

            _books.Add(_books.Find(b => b.Name==book.Name)==null?book:throw new SameBookalreadyAddedExpection("Book with This Name, Already Added!",new SameBookalreadyAddedExpection("test")));
        }

        public Book ShowInfo(string name)
        {
            return _books.Find(b => b.Name.ToLower() == name)
                ?? throw new BookNotFoundException("Book with that info doesn't exist! ",
                    new BookNotFoundException("test"));

        }

        public List<Book> Search(string search)
        {
            return _books.FindAll(b => b.Name.ToLower().Contains(search.ToLower()) ||
                                          b.Author.ToLower().Contains(search.ToLower()) ||
                                          b.PageCount.ToString().Contains(search) ||
                                          b.Genre.ToLower().Contains(search.ToLower()));
        }

        public List<Book> Filter(string author, string genre)
        {
            return _books.FindAll(b => b.Author.ToLower() == author.ToLower() && b.Genre.ToLower() == genre.ToLower());
        }
    }
}

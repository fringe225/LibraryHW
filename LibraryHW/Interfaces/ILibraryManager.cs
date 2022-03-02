using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LibraryHW.Models;

namespace LibraryHW.Interfaces
{
    internal interface ILibraryManager
    {
        public List<Book> Books { get; }

        public void Add(Book book);

        public Book ShowInfo(string name);
        public List<Book> Search(string search);

        public List<Book> Filter(string author,string genre);
    }
}

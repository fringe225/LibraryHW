using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHW.Exceptions
{
    internal class BookNotFoundException:Exception
    {
        public BookNotFoundException(string message) : base(message)
        {

        }

        public BookNotFoundException(string message,
            BookNotFoundException bookNotFoundException) : base(message, bookNotFoundException)
        {

        }
    }
}

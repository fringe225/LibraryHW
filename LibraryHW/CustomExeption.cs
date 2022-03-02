using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHW
{
    internal class CustomExeption:Exception
    {
        public CustomExeption(string message) : base(message)
        {

        }

        public CustomExeption(string message,CustomExeption SameBookalreadyAddedExpection) :base(message, SameBookalreadyAddedExpection)
        {

        }
    }

    public class CustomException : Exception
    {
        public Exception BookNotFoundException;


        public CustomException(string message) : base(message)
        {

        }
        public CustomException(string message, CustomException BookNotFoundException): base(message, BookNotFoundException)
        {

        }
    }

}

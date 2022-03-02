using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHW.Exceptions
{
    internal class SameBookalreadyAddedExpection:Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }

        public SameBookalreadyAddedExpection(string message,
            SameBookalreadyAddedExpection sameBookalreadyAddedExpection) : base(message, sameBookalreadyAddedExpection)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Repository
{
    public class NoEntriesFoundException : Exception
    {
        public NoEntriesFoundException()
        {
        }

        public NoEntriesFoundException(string message)
            : base(message)
        {

        }

        public NoEntriesFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

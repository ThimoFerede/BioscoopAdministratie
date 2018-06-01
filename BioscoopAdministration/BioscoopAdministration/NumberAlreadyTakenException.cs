using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration
{
    public class NumberAlreadyTakenException : Exception
    {
        public NumberAlreadyTakenException()
        {

        }

        public NumberAlreadyTakenException(string message) : base(message)
        {

        }

        public NumberAlreadyTakenException(string message, Exception inner) : base(message, inner)
        {

        }
    }

}

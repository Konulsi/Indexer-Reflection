using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Exceptions
{
    internal class InvalidPersonException : Exception
    {
        public InvalidPersonException(string message):base(message) { } 
    }
}

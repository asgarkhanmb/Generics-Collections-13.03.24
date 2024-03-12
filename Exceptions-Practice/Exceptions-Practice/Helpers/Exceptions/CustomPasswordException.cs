using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Helpers.Exceptions
{
    internal class CustomPasswordException:Exception
    {
        public CustomPasswordException(string letter) : base(letter) 
        {
        }
    }
}

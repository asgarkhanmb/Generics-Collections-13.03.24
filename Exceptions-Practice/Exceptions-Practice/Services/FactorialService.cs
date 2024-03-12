using Exceptions_Practice.Helpers.Exceptions;
using Exceptions_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Services
{
    internal class FactorialService : IFactorialService
    {
        public string FindFactorial(int? a)
        {
            int result = 1;
            try
            {
                if (a < 0)
                {
                    throw new CustomNumberNegativeException("Factorial menfi ola bilmez!");
                }
                else if (a == 0)
                {
                    result = 1;
                }

                for (int i = 1; i <= a; i++)

                {
                    result *= i;
                }
                return result.ToString();

            }
            catch (Exception letter)
            {

                return letter.Message;
            }
        }
    }
}

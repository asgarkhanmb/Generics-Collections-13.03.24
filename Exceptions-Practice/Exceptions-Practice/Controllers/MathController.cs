using Exceptions_Practice.Services;
using Exceptions_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Controllers
{
    public class MathController
    {
        private readonly IFactorialService _factorialService;

        public MathController()
        {
            _factorialService = new FactorialService();
        }

        public void FindFactroial()
        {
            Console.WriteLine("Add search factorial:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(_factorialService.FindFactorial(a));

        }
    }
}

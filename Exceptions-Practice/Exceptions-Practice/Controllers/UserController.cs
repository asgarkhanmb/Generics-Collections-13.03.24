using Exceptions_Practice.Models;
using Exceptions_Practice.Services;
using Exceptions_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Controllers
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new  UserService();
        }

        public void GetAll()
        {
            var users = _userService.GetAll();
            foreach (var user in users)
            {
                string result = $"{user.Name} {user.Surname} {user.Email} {user.Password}";
                Console.WriteLine(result);
            }
        }

        public void GetByUser()
        {
            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            var result=_userService.GetByUser(_userService.GetAll(),login, password);

            Console.WriteLine(result);
        }


        public void GetByLogin()
        {
            Console.WriteLine("Enter your login:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password= Console.ReadLine();

            Console.WriteLine(_userService.GetByLogin(_userService.GetAll(),email, password));

            

        }
    }
}

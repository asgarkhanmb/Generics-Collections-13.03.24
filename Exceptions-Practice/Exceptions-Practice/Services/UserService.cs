using Exceptions_Practice.Helpers.Exceptions;
using Exceptions_Practice.Models;
using Exceptions_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Services
{
    public class UserService : IUserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Name = "Asgarkhan",
                Surname = "Bayramov",
                Age =27,
                Email = "asgarkhanmb@code.edu.az",
                Password = "esger1"
            };

            User user2 = new()
            {
                Id = 2,
                Name = "Rashad",
                Surname = "Aghayev",
                Age =21,
                Email = "rashad@code.edu.az",
                Password = "resad2"
            };

            User user3 = new()
            {
                Id = 3,
                Name = "Bahruz",
                Surname = "Aliyev",
                Age =37,
                Email = "bahruz@code.edu.az",
                Password = "bahruz3"
            };


            User user4 = new()
            {
                Id = 4,
                Name = "Rufat",
                Surname = "Ismayilov",
                Age =21,
                Email = "rufet@code.edu.az",
                Password = "rufet4"
            };

            return new User[] { user1, user2, user3, user4 };
        }

        public string GetByUser(User[] users, string email, string password)
        {
            try
            {
                var result = users.FirstOrDefault(m => m.Email == email && m.Password == password);
                if (result != null)
                {
                    return "User found";
                }
                else
                {
                    throw new CustomIsNullOrEmptyException("Data not found!");
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string GetByLogin(User[] users, string email, string password)
        {
            try
            {
                var result = users.FirstOrDefault(m => m.Password == password);
                if (password.Length < 6)
                {
                    throw new CustomPasswordException("Passwordun simvollarinin sayi 6-dan kicik ola bilmez!");
                }
                else
                {
                    return "Password correct";
                }


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


    }
}

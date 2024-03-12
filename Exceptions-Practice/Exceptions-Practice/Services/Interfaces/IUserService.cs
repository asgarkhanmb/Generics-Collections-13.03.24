using Exceptions_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Services.Interfaces
{
    public interface IUserService
    {
        User[] GetAll(); 
        public string GetByUser(User[] users,string login,string password);

        public string GetByLogin(User[] users, string login,string password);   

    }
}

using Exceptions_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id=null);

        List<Customer> GetAllByAge(int age);
        
        int GetCount();

        List<Customer> OrderByAge(List<Customer> customers, string asc);
        
    }
}

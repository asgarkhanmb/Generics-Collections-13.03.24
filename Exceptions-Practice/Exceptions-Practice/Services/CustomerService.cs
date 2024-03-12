using Exceptions_Practice.Data;
using Exceptions_Practice.Models;
using Exceptions_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Practice.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id=null)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);

        }
        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age ==age).ToList();
        }


        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(List<Customer>customers,string asscending)
        {
            if (asscending.ToLower() == "asc")
            {
                return customers.OrderBy(m=>m.Age).ToList();
            }
            else if(asscending.ToLower() =="desc")
            {
                return customers.OrderByDescending(m=>m.Age).ToList();
            }
            else
            {
                throw new ArgumentException("parametr asc or desc");
            }
        }
    }
}

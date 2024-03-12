using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Book:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Book()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class IntList
    {
        private int[] intArray;
        
        public IntList()
        {
            intArray = Array.Empty<int>();
        }
        public void Add(int num) 
        {
            Array.Resize(ref intArray,intArray.Length+1);
            intArray[intArray.Length-1] = num;
        }
        public int[] GetAll()
        {
            return intArray;
        }
    }
}

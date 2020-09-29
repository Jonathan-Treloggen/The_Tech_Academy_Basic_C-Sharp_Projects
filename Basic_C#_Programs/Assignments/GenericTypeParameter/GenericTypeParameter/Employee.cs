using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeParameter
{
    public class Employee<T>
    {

        public List<T> things { get; set; }

        public void printAll()
        {
            Console.WriteLine(things);
        }
    }
}

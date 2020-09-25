using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Jon";
            employee.ID = "72";
          
            bool compare = employee.FirstName == employee.ID;
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
}

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
            Employee employee = new Employee(72, "Jon");
            employee.display();

            Console.WriteLine("and");

            Employee employee2 = new Employee(23, "Cody");
            employee2.display();

            if (employee == employee2)
            {
                Console.WriteLine("\nDo have the same I number.");
            }
            else
            {
                Console.WriteLine("\nDon't have the same ID number.");
            }
            Console.ReadLine();
        }
    }
}

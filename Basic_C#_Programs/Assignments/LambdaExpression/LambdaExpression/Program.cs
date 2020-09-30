using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() {FirstName = "Jon", LastName = "Treloggen", ID = 72 });
            Employees.Add(new Employee() {FirstName = "Joe", LastName = "Mixon", ID =  28 });
            Employees.Add(new Employee() { FirstName = "Megan", LastName = "Treloggen", ID = 13 });
            Employees.Add(new Employee() { FirstName = "Cody", LastName = "Gilbert", ID = 23 });
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Young", ID = 8 });
            Employees.Add(new Employee() { FirstName = "Megan", LastName = "Gilbert", ID = 11 });
            Employees.Add(new Employee() { FirstName = "Eli", LastName = "Cass", ID = 77 });
            Employees.Add(new Employee() { FirstName = "Carisa", LastName = "Madewell", ID = 22 });
            Employees.Add(new Employee() { FirstName = "Ness", LastName = "Tree", ID = 33 });
            Employees.Add(new Employee() { FirstName = "Carl", LastName = "Madewell", ID = 2 });

            var JoesList = new List<Employee>();

            foreach (var employee in Employees)
            {
                if (employee.FirstName == "Joe")
                {
                    JoesList.Add(employee);
                    Console.WriteLine(employee.FirstName);
                }
            }

            List<Employee> TrueJoesList = Employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee Joes in TrueJoesList)
            {
                Console.WriteLine(Joes.FirstName);
            }

            List<Employee> highID = Employees.Where(x => x.ID > 5).ToList();

            foreach (Employee hiID in highID)
            {
                Console.WriteLine(hiID.ID);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public class Employee
    {
        private string firstName;
        private int employeeID;

        public Employee(int employeeID, string firstName)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
        }

        public void display()
        {
            Console.WriteLine("Employee number: " + employeeID + " first name: " + firstName);
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.employeeID == employee2.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.employeeID != employee2.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Person
    {
        public static Employee operator== (Employee employee, Person person)
        {
            employee.Person.Add(person);
            return employee;
        }
        public static Employee operator !=(Employee employee, Person person)
        {
            employee.Person.Remove(person);
            return employee;
        }
    }
}

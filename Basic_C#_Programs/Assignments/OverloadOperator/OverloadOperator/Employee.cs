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
        public string FirstName { get; set; }
        public string ID { get; set; }


        public static bool operator ==(Employee firstName, Employee id)
        {
            return (firstName == id);
        }

        public static bool operator !=(Employee firstName, Employee id)
        {
            return !(firstName == id);
        }
    }
}

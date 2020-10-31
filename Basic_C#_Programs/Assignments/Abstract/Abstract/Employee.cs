using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("\nCurrent satic: \nHas quit");
        }
    }
}

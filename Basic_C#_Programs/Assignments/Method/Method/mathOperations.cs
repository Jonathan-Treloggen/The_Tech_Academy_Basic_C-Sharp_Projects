using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class mathOperations
    {
        public int doMath(int number1)
        {
            int answer = number1 +5;
            return answer;
        }

        public int doMath(decimal number1)
        {
            int answer = Convert.ToInt32(number1) * 5;
            return answer;
        }

        public int doMath(string number1)
        {
            int answer = Convert.ToInt32(number1) - 5;
            return answer;
        }
            
    }
}

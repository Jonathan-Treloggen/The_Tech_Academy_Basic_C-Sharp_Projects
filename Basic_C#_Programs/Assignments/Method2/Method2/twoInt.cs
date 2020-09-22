using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class twoInt
    {
        public static int optionalMethods(int enteredNumber, int constantNum = 10)
        {
            int result = enteredNumber + constantNum;
            return result;
        }
    }
}

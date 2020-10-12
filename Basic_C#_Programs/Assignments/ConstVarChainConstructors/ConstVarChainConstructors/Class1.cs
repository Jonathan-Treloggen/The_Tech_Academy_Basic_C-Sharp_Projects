using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainConstructors
{
    public class Class1
    {
        public Class1(int num) : this(72, "Jon")
        {
        }
        public Class1(int num, string name)
        {
            bestName = name;
            bestNum = num;
        }
        public int bestNum { get; set; }
        public string bestName { get; set; }
    }
}

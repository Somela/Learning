using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    internal class ConditionalOperators
    {
        //int i = 10, j = 20;
        public void Conditional(int i, int j)
        {
            Console.WriteLine(i == j ? "Equal" : "Not Equal"); //   Not Equal
            Console.WriteLine(i > j ? "Greater" : "Less");  //Less
            Console.WriteLine(i < j ? "Less" : "Greater"); //  Less
        }
    }
}

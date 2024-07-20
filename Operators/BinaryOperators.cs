using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    internal class BinaryOperators
    {
        public void binaryOperator(int i, int j)
        {
            Console.WriteLine(i & j); //Bitwise AND
            Console.WriteLine(i | j); //Bitwise OR
            Console.WriteLine(i ^ j); //Bitwise XOR
            Console.WriteLine(~i); //Bitwise NOT
        }
    }
}

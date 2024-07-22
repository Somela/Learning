using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class BitWiseOperator
    {
        public void BitWiseOperators(int i, int j)
        {
            Console.WriteLine(i & j); //Bitwise AND //0
            Console.WriteLine(i | j); //Bitwise OR //30
            Console.WriteLine(i ^ j); //Bitwise XOR    //30
            Console.WriteLine(~i); //Bitwise Complement     // -11
            Console.WriteLine(i << 2); //Left Shift   //40
            Console.WriteLine(i >> 2); //Right Shift //2
        }
    }
}

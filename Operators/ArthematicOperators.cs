using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    public class ArthematicOperators
    {
        public void Arthematic(int i, int j)
        {
            Console.WriteLine(i + j); //Addition
            Console.WriteLine(i - j); //Subtraction
            Console.WriteLine(i * j); //Multiplication
            Console.WriteLine(i / j); //Division
            Console.WriteLine(i >> j); //Right Shift
            Console.WriteLine(i << j); //Left Shift
        }
    }
}

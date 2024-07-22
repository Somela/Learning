using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    internal class AssignmentOperator
    {
        //int i = 10, j = 20;
        public void Assignment(int i, int j)
        {
            Console.WriteLine(i = j); //20 ==> i=20
            Console.WriteLine(i += j); //i=i + j; // 40
            Console.WriteLine(i -= j); //i = i = j; // 20
            Console.WriteLine(i *= j); //i = i * j; // 400
            Console.WriteLine(i /= j);  //i = i / j; // 20
            Console.WriteLine(i %= j);  //i = i%j; // 0
        }
    }
}

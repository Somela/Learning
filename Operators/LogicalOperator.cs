using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    public class LogicalOperator
    {
        //int i = 10, j = 20;
        public void Logical(int i, int j)
        {
            Console.WriteLine(i == j  && i > j); //False ==> False && False = False
            Console.WriteLine(i == j || i > j); //False ==> False || False = False
            Console.WriteLine(!(i == j && i > j)); //True 
        }
    }
}

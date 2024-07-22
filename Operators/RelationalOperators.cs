using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    public class RelationalOperators
    {
        //x=10, y=20
        public void Relational(int i, int j)
        {
            Console.WriteLine(i == j); //Equal to   //False
            Console.WriteLine(i != j); //Not Equal to //True
            Console.WriteLine(i > j); //Greater than //False
            Console.WriteLine(i < j); //Less than   //True
            Console.WriteLine(i >= j); //Greater than or Equal to   //False
            Console.WriteLine(i <= j); //Less than or Equal to  //True
        }
    }
}

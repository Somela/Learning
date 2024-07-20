using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ControlStatements
{
    public class IfConditions
    {
        //int i = 10, j = 20;
        public void IfCondition(int i, int j)
        {
            if (i == j)
            {
                Console.WriteLine("i and j are equal");
            }
            else
            {
                Console.WriteLine("i and j are not equal");
            }
        }
        // Output: i and j are not equal

        public void NestedIfCondition(int i, int j)
        {
            if (i == j)
            {
                Console.WriteLine("i and j are equal");
            }
            else
            {
                if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
                else
                {
                    Console.WriteLine("i is less than j");
                }
            }

            // Output: i is less than j
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Task.Loops
{
    internal class Print_0_InTriangle
    {
        //print like this
        // 0
        // 0 0
        // 0 0 0
        // 0 0 0 0
        // 0 0 0 0 0
        public void Print_0_InTriangleExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}

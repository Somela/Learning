using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Loops
{
    internal class ForEachLoop
    {
        public void ForEachLoopExample()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

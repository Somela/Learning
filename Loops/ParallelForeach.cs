using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Loops
{
    internal class ParallelForeach
    {
        public void ParallelForeachExample()
        { 
            //Prints 1 to 13
            int[] arr = { 1, 2, 3, 4, 5, 6,7,8,9,10,11,12,13 };
            Parallel.ForEach(arr, i =>
            {
                Console.WriteLine(i);
            });
        }
    }
}

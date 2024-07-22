using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Loops
{
    internal class DoWhile
    {
        //prints 0 to 4
        public void DoWhileExample()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
    }
}

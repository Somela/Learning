using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class JumpStatements
    {
        
        public void jumpStatements()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            // Output: 0 1 2 3 4

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            // Output: 0 1 2 3 4 6 7 8 9

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    goto myLabel;
                }
                Console.WriteLine(i);
            }
            myLabel:
            Console.WriteLine("Jumped to myLabel");
            // Output: 0 1 2 3 4 Jumped to myLabel
        }
    }
}

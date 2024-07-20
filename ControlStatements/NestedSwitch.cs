using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ControlStatements
{
    internal class NestedSwitch
    {
        //int i = 1, j = 2;
        public void NestedSwitchCase(int i, int j)
        {
            switch (i)
            {
                case 1:
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("i=1, j=1");
                            break;
                        case 2:
                            Console.WriteLine("i=1, j=2");
                            break;
                        default:
                            Console.WriteLine("i=1, j=Invalid");
                            break;
                    }
                    break;
                case 2:
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("i=2, j=1");
                            break;
                        case 2:
                            Console.WriteLine("i=2, j=2");
                            break;
                        default:
                            Console.WriteLine("i=2, j=Invalid");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            // Output: i=1, j=2
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ControlStatements
{
    internal class SwitchCase
    {
        //int i = 2;
        public void Switch(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            // Output: Two
        }
    }
}

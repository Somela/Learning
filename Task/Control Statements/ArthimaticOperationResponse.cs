using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Task.Operations
{
    public class ArthimaticOperationResponse
    {
        public string FindArthimatic(int operation)
        {
            if (operation == 1)
            {
                return "Addition";
            }
            else if (operation == 2)
            {
                return "Subtraction";
            }
            else if (operation == 3)
            {
                return "Multiplication";
            }
            else if (operation == 4)
            {
                return "Division";
            }
            else
            {
                return "Invalid Operation";
            }
        }
    }
}

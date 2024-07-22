using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Task.Operations
{
    public class SwitchResponse
    {
        public int ArthematicOperation(string operation, int i, int j)
        {
            switch (operation)
            {
                case "Addition":
                    return i + j;
                case "Substraction":
                    return i - j;
                case "Multiplication":
                    return i * j;
                case "Division":
                    return i / j;
                default:
                    return 0;
            }
        }
    }
}

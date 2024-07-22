using Learning.Task.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter How many times you want to repeat");
            int repeat = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {

                Console.WriteLine("Please Enter X Value");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Y Value");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("\t" + "1. Addition\n\t2. Substraction\n\t3 .Multiplication\n\t4. Division\n");
                int z = int.Parse(Console.ReadLine());
                ArthimaticOperationResponse arthimaticOperationResponse = new ArthimaticOperationResponse();
                string operation = arthimaticOperationResponse.FindArthimatic(z);
                Console.WriteLine("Selected Operation is: " + operation);
                SwitchResponse switchResponse = new SwitchResponse();
                double result = switchResponse.ArthematicOperation(operation, x, y);
                Console.WriteLine("Result is: " + result);
            }
            Console.ReadKey();
        }
    }
}

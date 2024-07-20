using Learning.Operators;
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
            //Console.WriteLine("Hello World!");
            //ArthematicOperators arthematicOperators = new ArthematicOperators();
            //arthematicOperators.Arthematic(10, 20);
            //RelationalOperators relationalOperators = new RelationalOperators();
            //relationalOperators.Relational(10, 20);
            //Uniary_Operator uniary_Operator = new Uniary_Operator();
            //uniary_Operator.Uniary(10, 20);
            //LogicalOperator logicalOperator = new LogicalOperator();
            //logicalOperator.Logical(10, 20);
            BitWiseOperator bitwiseOperator = new BitWiseOperator();
            bitwiseOperator.BitWiseOperators(10, 20);
            Console.ReadLine();
        }
    }
}

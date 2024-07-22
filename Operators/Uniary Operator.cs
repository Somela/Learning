using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Operators
{
    public class Uniary_Operator
    {
        //i=10,j=20
        public void Uniary(int i, int j)
        {
            Console.WriteLine(i++); //Post Increment //10
            Console.WriteLine(i); //Incremented value   //11
            Console.WriteLine(++j); //Pre Increment     //21
            Console.WriteLine(j); //Incremented value   //21
            Console.WriteLine(i--); //Post Decrement    //11
            Console.WriteLine(i); //Decremented value   //10
            Console.WriteLine(--j); //Pre Decrement     //20
            Console.WriteLine(j); //Decremented value   //20
        }
    }
}

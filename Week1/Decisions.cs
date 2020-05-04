using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Decisions
    {
        static void Main(string[] args)
        {
            int num1, num2;

            num1 = Utils.GetNumber("Enter your first number");
            num2 = Utils.GetNumber("Enter your second number");

            if (num1 > num2)
            {
                Console.WriteLine("{0} is {1} greater than", num1, num2);
            } else
            {
                Console.WriteLine("{0} is {1} greater than", num2, num1);
                
            }
        }
    }
}

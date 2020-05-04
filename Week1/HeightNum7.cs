using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class HeightNum7
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int heightInInches = Utils.GetNumber("Enter your height in inches ");
                int age = Utils.GetNumber("How old are you? ");
                if (heightInInches <= 36 && age >= 9)
                {
                    Console.WriteLine("You still have some growing to do ");
                }
                else if (heightInInches >= 36 && age >= 9)
                {
                    Console.WriteLine("You are on your way young person ");
                }
                else if (heightInInches > 60 && age <= 18)
                {
                    Console.WriteLine("You are a little short, but you still have time to grow ");
                }
                else if (heightInInches > 68 && age >= 18)
                {
                    Console.WriteLine("Your height is normal and any taller than this is a plus ");
                }
            }
        }
    }
}
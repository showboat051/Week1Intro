using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Lab3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double dblHeight, dblWeight, dblBMI;

                dblHeight = Utils.GetNumber("Enter Height in inches: ");
                dblWeight = Utils.GetNumber("Enter Weight in pounds: ");

                dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

                Console.WriteLine("Your BMI is " + dblBMI);

                if (dblBMI < 18.5)
                {
                    Console.WriteLine("BMI < 18.5 - Underweight:");
                }
                else if (dblBMI <= 24.9)
                {
                    Console.WriteLine("BMI between 18.5 and 24.9 is normal");
                }
                else if (dblBMI <= 29.9)
                {
                    Console.WriteLine("BMI between 25 and 29.9 - overweight");
                }
                else
                {
                    Console.WriteLine("BMI >= 30 - Obese");
                }
                Console.ReadLine();
            }
        }
    }
}

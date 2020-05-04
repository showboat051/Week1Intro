using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class FindTemperature
    {
        static void Main(string[] args)
        {
            int temp = Utils.GetNumber("Enter a temperature ");
   
                if (temp < 0)
                {
                    Console.WriteLine("freezing");
                }
                else if (temp > 0 && temp <= 10)
                {
                    Console.WriteLine("Very Cold weather");
                }
                else if (temp > 10 && temp <= 20)
                {
                    Console.WriteLine("Cold weather");
                }
                else if (temp > 20 && temp <= 30)
                {
                    Console.WriteLine("Normal");
                }
                else if (temp > 30 && temp <= 40)
                {
                    Console.WriteLine("It's hot");
                }
                else if (temp >= 40)
                {
                    Console.WriteLine("HOT");
                }

            for (int rd = 0; rd < 100; rd++)
            {
                Console.WriteLine($"{rd}");
            }
            }
        }
    }


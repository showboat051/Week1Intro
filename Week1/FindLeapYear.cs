using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class FindLeapYear
    {
        static void Main(string[] args)
        {
            int currentYear = Utils.GetNumber(" Enter a year ");
            if (DateTime.IsLeapYear(currentYear))
            {
                Console.WriteLine("Leap Year");
            } else
            {
                Console.WriteLine("NOT A LEAP YEAR");
            }
        }
    }

}

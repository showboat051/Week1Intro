using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Lab4
    {
        static void Main(string[] args)
        {
            int nLargest;
            int nSmallest;
            int nCurrent;
            
            Console.WriteLine("Enter a number ");
            
            string strEntry = Console.ReadLine(); ;
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Q to Quit");

            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);
                Console.WriteLine("Enter Q to Quit");
                 
                if (nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if ( nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }
            }

            Console.WriteLine("The largest number is " + nLargest + ".");
            Console.WriteLine("The smallest number is " + nSmallest + ".");

            Console.ReadLine();


        }
    }
}

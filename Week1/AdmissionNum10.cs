using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class AdmissionNum10
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int mathGrade = Utils.GetNumber("What was your MATH grade? ");
                int phyGrade = Utils.GetNumber("What was your PHY grade? ");
                int chemGrade = Utils.GetNumber("What was your CHEM grade? ");
                int totalGrade = mathGrade + phyGrade + chemGrade;
                int mpGrade = mathGrade + phyGrade;

                if (totalGrade >= 180 || mpGrade >= 140)
                {
                    Console.WriteLine("Congratulations, you have been admitted");
                }
                else if (totalGrade <= 180 || mpGrade <= 140)
                {
                    Console.WriteLine("Sorry, keep raising those grades up ");
                }
            }
        }
    }
}
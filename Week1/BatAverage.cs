using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class BatAverage
    {
       private static void guest(string[] args)
        {


            // Variable declaration
            string strPlayerName;
            double dblHits, dblAtBats; // later we will see the need to change this to dboule dblHits, dblAtBats
            double dblBattingAverage;

            Console.WriteLine("This program calculates a baseball player's batter average");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter player's name: ");
            strPlayerName = Console.ReadLine();                 //  or we could use the Utils class strPlayerName = Utils.GetInput("Enter player's name");

            //  prompt for hits and at bats
            Console.Write("Enter the player's # of hits: ");
            dblHits = Convert.ToInt32(Console.ReadLine());        //  or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of hits: ");
            Console.Write("Enter the player's # of at bats: ");
            dblAtBats = Convert.ToInt32(Console.ReadLine()); // or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of at bats: ");
                                                           // calculation
            dblBattingAverage = dblHits / dblAtBats;
            Console.WriteLine($"{strPlayerName}'s batting averate is {dblBattingAverage}");

        }
    }
}

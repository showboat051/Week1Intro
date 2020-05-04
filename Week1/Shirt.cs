using System;

namespace Week1
{
    class Shirt
    {
        static void MainShirt(string[] args)
        {
            string yourShirt = "just as plain as day gray";
            string temp;
            int index;
            bool found;

            temp = yourShirt.Substring(12);
            Console.WriteLine(temp);
            temp = yourShirt.Substring(19);
            Console.WriteLine(temp);
        } // end of main method
    }
}

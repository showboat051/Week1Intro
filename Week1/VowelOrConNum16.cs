using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class VowelOrConNum16
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] vowels = { "A", "E", "I", "O", "U" };

                string getLetter = Utils.GetInput("Enter a letter ");


                for (int i = 0; i < vowels.Length; i++)
                {
                getLetter.ToUpper();
                    if (getLetter == vowels[i])
                    {
                        Console.WriteLine("This letter is a vowel");
                    }
                    else if (getLetter != vowels[i])
                    {
                        Console.WriteLine("This is a consonant");
                    }

                }


            }

        }
    }
}

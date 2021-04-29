using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class10
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            int vowel = 0;
            string inputString = Console.ReadLine();
            for(int index=0; index<inputString.Length;index++)
            {
                if (inputString[index]=='a'|| inputString[index] == 'e' ||
                    inputString[index] == 'i' || inputString[index] == 'o' ||
                    inputString[index] == 'u')
                {
                    vowel++;
                }
            }
            Console.WriteLine("Total number of vowels in the string is : {0}",vowel);
            Console.ReadLine();

        }
    }
}

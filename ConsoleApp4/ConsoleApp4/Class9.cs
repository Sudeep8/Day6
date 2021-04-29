using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class9
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string inputString = Console.ReadLine();
            char[] reversedStringArray = new char[inputString.Length];
            
            for(int i= inputString.Length-1; i>=0;i--)
            {
                reversedStringArray[i] = inputString[i];
            }
            string reversedString = new string(reversedStringArray);
            if(reversedString == inputString)
            {
                Console.WriteLine("String is a Palindrome");
            }
            else
            {
                Console.WriteLine("String is not a Palindrome");
            }
            Console.ReadLine();

        }
    }
}

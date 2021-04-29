using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);

            Console.ReadLine();
        }

    }
}

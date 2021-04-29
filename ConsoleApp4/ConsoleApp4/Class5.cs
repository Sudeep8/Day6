using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class5
    {
        static void Main()
        {
            int result;
            int.TryParse("233", out result);
            Console.WriteLine(result);
            if(result==0)
            {
                Console.WriteLine("Input is not a Number ");
            }
            else
            {
                Console.WriteLine("Input is a Number ");
            }
            Console.ReadLine();

        }
    }
}

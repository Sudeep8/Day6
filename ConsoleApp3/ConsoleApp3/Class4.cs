using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class4
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter the age of person: ");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 60)
            {
                Console.WriteLine("you are a senior citizen");
            }
            else if (Number < 18)
            {
                Console.WriteLine("you are not eligible for voting");
            }
            else if (Number >= 18) 
            {
                Console.WriteLine("eligible for voting");
            }
            Console.ReadLine();
        }
        }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    
    class Class3
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter the age of person: ");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 18)
            {
                Console.WriteLine("Person is able to vote");
            }
            else
            {
                Console.WriteLine("Person is not able to vote");
            }
            Console.ReadLine();
        }
        }
}

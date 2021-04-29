using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter what you want to do. \n 1,Addition \n 2.Multiplication");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("ADD");
                    break;
                case 2:
                    Console.WriteLine("Multiply");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
            Console.ReadLine();
        }
        
        }
}

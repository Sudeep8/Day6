using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class2
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, result;
            Console.WriteLine("Enter FirstNumber :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SecondNumber :");
            secondNumber = Convert.ToInt32(Console.ReadLine());


            result = firstNumber + secondNumber;
            Console.WriteLine("Result :" + result);
            Console.ReadLine();

        }
    }
}

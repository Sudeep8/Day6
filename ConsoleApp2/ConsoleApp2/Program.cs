using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            Console.WriteLine("Sum of "+a+"+"+b+"= "+(a+b));
            Console.WriteLine("Diff of " + a + "-" + b + "= " + (a - b));
            Console.WriteLine("Multiplication of " + a + "x" + b + "= " + (a * b));
            Console.WriteLine("Division of " + a + "/" + b + "= " + (a / b));
            Console.ReadLine();
        }
    }
}

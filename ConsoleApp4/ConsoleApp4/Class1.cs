using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some value");
            var x= Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine(x.GetType());
            Console.ReadLine();
        }
    }
}

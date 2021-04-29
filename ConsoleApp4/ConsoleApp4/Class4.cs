using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class3
    {
        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping");

           Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
        static void Main(string[] args)
        {
            Class3 class1 = new Class3();
            int a = 6, b = 5;
            class1.Swap(ref a,ref b);
            Console.WriteLine("Before swapping");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();

        }
    }
}

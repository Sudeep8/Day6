using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class3
    {
        void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a="+a);
            Console.WriteLine("b=" + b);

        }
        static void Main(string[] args)
        {
            Class3 class1 = new Class3();
            class1.Swap(6,5);
            Console.ReadLine();
            
        }
    }
}

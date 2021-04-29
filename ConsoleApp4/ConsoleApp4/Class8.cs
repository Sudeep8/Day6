using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class8
    {
        static void Main()
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("Using Equality operator {0}", str == str2);
            Console.WriteLine("Using Equals() method {0}", str.Equals(str2));
            Console.ReadLine();

        }
    }
}

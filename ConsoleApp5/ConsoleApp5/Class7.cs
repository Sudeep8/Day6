﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class7
    {
        public static void Main()
        {

            String str = "It is a bad color";

            Console.WriteLine("String    : " + str);
            String str2 = "is a";
            Console.WriteLine("Sub String: " + str2);
            if(str.Contains(str2))
            {
                Console.WriteLine("Sub tring 'is a' is present " );
            }
            Console.ReadLine();
        }
    }
}

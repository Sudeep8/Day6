using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class GFG
    {

        // Function to print all sub
        // strings
        static void subString(string str,int n)
        {

            // Pick starting point
            for (int len = 1; len <= n;len++)
            {
                // Pick ending point
                for (int i = 0;i <= n - len; i++)
                {
                    // Print characters
                    // from current
                    // starting point to
                    // current ending
                    // point.
                    int j = i + len - 1;

                    for (int k = i; k <= j;k++)
                        Console.Write(str[k]);

                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        // Driver program to test
        // above function
        static public void Main()
        {
            string str = "abc";
            subString(str, str.Length);
        }
    }
}

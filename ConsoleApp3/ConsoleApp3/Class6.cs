using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class6
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum=0;
            Console.WriteLine("Enter the elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i]; 
            }
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }
        
        }
}

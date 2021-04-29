using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public enum Salutation
    {
        Mr=0,
        Ms=1,
        Mrs=2,
        Dr=3
    }
    class Class9
    {
        static void Main(string[] args)
        {
            Salutation salutation;
            string name;
            Console.WriteLine("Enter the salutation:");
            salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
            Console.WriteLine("Enter your name:");
            name= Console.ReadLine();
            Console.Write("\n Your name is: {0}", salutation.ToString());
            Console.Write("." + name);
            Console.ReadLine();
        }
    }
}

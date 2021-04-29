using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Dog
    {
        public void Speak()
        {
            Console.WriteLine("Bark !");
        }
    }
    class Class7
    {
        static void Main()
        {
            Object o = new Dog();
            Dog dog = o as Dog;
            if (dog != null)
                dog.Speak();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class AbstractClass
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }

        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Eating");
                Console.ReadLine();
            }
        }

        public abstract class Animal
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }

            public abstract void Eat();
            
        }
        
    }
}

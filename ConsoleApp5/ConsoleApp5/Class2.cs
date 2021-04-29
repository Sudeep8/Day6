using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Vehicle
    {
        public string Brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut !");
        }
        
    }
    class Car : Vehicle

    {
        Car(string _model)
        {
            modelName = _model;
        }
        public string modelName { get; set; }

    
        public static void Main()
        {
            Car mycar = new Car("Mustang");
            mycar.honk();
            Console.WriteLine("Details of Car: ");
            Console.ReadLine();
        }
    }
}

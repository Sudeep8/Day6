using System;
using System.Collections.Generic;
using System.Text;

public class FirstInterface
{
    public static void Main(string[] args)
    {
        Car car = new Car(0);
        Console.WriteLine("Enter Amount of Fuel");
        int fuel = int.Parse(Console.ReadLine());
        if (car.Refuel(fuel))


        {
            car.Drive();
        }
        Console.ReadLine();
    }

    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not driving");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
            
        }
        
    }
}
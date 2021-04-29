using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
interface Inter1
    {

    }
void display();
}
class testClass : Inter1 //class is inherited and interfaceis implemented
{
    public void display()
    {
        Console.WriteLine("Hello");
    }
    public status void Main()
    {
        testClass t = new testClass();
        t.display();
        Console.ReadLine();

    }
}
}
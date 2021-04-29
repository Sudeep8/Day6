using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class Class6
    {
        public static void Main()
        {

            System.DateTime datetime = DateTime.Now;
            Console.WriteLine("Today's date and time is = " + datetime);
            Console.WriteLine("The year is = " + datetime.Year);
            Console.WriteLine("The month is = " + datetime.Month);
            Console.WriteLine("The day is = " + datetime.Day);
            Console.WriteLine("The hour is = " + datetime.Hour);
            Console.WriteLine("The minute is = " + datetime.Minute);
            Console.WriteLine("The second is = " + datetime.Second);
            Console.WriteLine("The millisecond is = " + datetime.Millisecond);
            Console.ReadLine();
        }
        
    }
}

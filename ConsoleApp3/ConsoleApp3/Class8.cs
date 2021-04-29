using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        static void Main()
        {
            Student student = new Student();
            student.RollNumber = 1;
            student.Name = "Sudeep S";
            student.Gender = "Male";
            Console.WriteLine(student.RollNumber + "\t" + student.Name + "\t" + student.Gender);
            Console.ReadLine();
        }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question1
    {
        public static void Run()
        {
            string name;
            int rollNumber;
            double marks;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n----- Student Details -----");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Marks: " + marks);
        }
    }
}
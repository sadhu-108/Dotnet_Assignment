using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question3
    {
        public static void Run()
        {
            int number;

            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
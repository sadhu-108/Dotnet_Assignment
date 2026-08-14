using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2
    {
        public static void Run()
        {
            double num1, num2;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum = " + (num1 + num2));
            Console.WriteLine("Difference = " + (num1 - num2));
            Console.WriteLine("Product = " + (num1 * num2));

            if (num2 != 0)
            {
                Console.WriteLine("Quotient = " + (num1 / num2));
                Console.WriteLine("Remainder = " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("Division by Zero is not possible.");
            }
        }
    }
}
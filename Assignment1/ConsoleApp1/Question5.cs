using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question5
    {
        public static void Run()
        {
            double num1, num2, result;
            int choice;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nCalculator Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division by Zero is not possible.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
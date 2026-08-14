using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question10
    {
        public static void Run()
        {
            int choice;
            Console.WriteLine("Developed by Mukund Karki (Class RollNo: 35,  Uni RollNo: 12584200122)");

            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Check Even/Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Calculate Factorial");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int number;

                        Console.Write("Enter a Number: ");
                        number = Convert.ToInt32(Console.ReadLine());

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("Even Number");
                        }
                        else
                        {
                            Console.WriteLine("Odd Number");
                        }
                        break;

                    case 2:
                        int a, b, c, largest;

                        Console.Write("Enter First Number: ");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Second Number: ");
                        b = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Third Number: ");
                        c = Convert.ToInt32(Console.ReadLine());

                        largest = a;

                        if (b > largest)
                        {
                            largest = b;
                        }

                        if (c > largest)
                        {
                            largest = c;
                        }

                        Console.WriteLine("Largest Number = " + largest);
                        break;

                    case 3:
                        int n;
                        long factorial = 1;

                        Console.Write("Enter a Number: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= n; i++)
                        {
                            factorial = factorial * i;
                        }

                        Console.WriteLine("Factorial = " + factorial);
                        break;

                    case 4:
                        Console.WriteLine("Program Exited.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);

            
        }
    }
}
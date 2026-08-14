using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question6
    {
        public static void Run()
        {
            int n;

            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even Numbers:");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers:");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
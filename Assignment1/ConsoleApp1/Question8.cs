using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question8
    {
        public static void Run()
        {
            int number;
            int count = 0;

            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }
    }
}
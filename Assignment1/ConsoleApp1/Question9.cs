using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question9
    {
        public static void Run()
        {
            int number, reverse = 0, remainder, original;

            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            original = number;

            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            if (original == reverse)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }
        }
    }
}
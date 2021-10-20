using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("No Number in between");
            }

            else
            {
                int d1 = Math.Min(num1, num2);
                int d2 = Math.Max(num1, num2);
                Console.WriteLine($"\nThe numbers between {d1} and {d2} are ");
            for (int i = d1+1; i < d2; i++)
                {
                    Console.WriteLine(i);
                }
            }
    }
        }
 }

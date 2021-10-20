using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"The factorial of {num} is {fact}");
        }
    }
}

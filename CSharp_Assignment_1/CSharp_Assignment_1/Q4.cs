using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is an even number");
            }
            else
                Console.WriteLine($"{n} is an odd number");
        }
    }
}

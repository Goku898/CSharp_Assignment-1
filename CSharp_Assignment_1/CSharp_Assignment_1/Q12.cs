using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q12
    {
        static void Main(string[] args)
        {
            int lar = 0;
            Console.WriteLine("Input three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                 lar = a;

            }
            else if (b > c)
            {
                 lar = b;
            }
            else
            {  lar = c; }

            Console.WriteLine($"Largest among {a},{b} and {c} is {lar} ");
        }
    }
}

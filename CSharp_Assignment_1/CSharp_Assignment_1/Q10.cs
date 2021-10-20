using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine($"{num} * {i}  = {i * num}");
            }
        }
    }
}

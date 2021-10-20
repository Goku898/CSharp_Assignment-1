using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers between 200 and 300 that are divisible by 7 are:");
            for(int i=200;i<=300;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

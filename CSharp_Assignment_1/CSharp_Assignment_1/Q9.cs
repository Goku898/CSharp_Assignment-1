using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q9
    {
        static void Main(string[] args)
        {
            int f0 = 0,f1=1;
            Console.WriteLine("Fibonacci series till 40 is :");
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            for (int i=1;i<40;i++)
            {
                int fib = f0 + f1;
                Console.WriteLine(fib);
                f0 = f1;
                f1 = fib;


            }

        }
    }
}

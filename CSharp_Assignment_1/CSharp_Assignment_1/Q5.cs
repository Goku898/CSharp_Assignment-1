using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q5
    {
        static void Main(string[] args)
        { Console.WriteLine("Input the array size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int even = 0, odd = 0;
            Console.WriteLine("Input the elements");
            for(int i=0;i<n;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                    odd++;
            }

            Console.WriteLine($"Odd number count is {odd} and Even number count is {even}");




        }
    }
}

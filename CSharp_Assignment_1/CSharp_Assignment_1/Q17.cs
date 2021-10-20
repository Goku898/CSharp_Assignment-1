using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st Word");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd Word");
            string s2 = Console.ReadLine();
            if(s1==s2)
            {
                Console.WriteLine($"Both {s1} and {s2} are same");
            }
            else
            {
                Console.WriteLine($"Both {s1} and {s2} are not same");
            }

        }
    }
}

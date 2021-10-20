using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            string reverse = null;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            Console.WriteLine(reverse);
        }
    }
}

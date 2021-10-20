using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q18
    {
        static void Main(string[] args)
        {
            string reverse = null;
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            word=word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            if(word==reverse)
            {
                Console.WriteLine($"{word} is a palindrome");
            }
            else
                Console.WriteLine($"{word} is not a palindrome");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q14
    {
        static void Main(string[] args)
        {
            int total = 0, min = 0, max = 0, avg = 0;
            Console.WriteLine("Enter the marks ");
            int[] marks = new int[10];
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                total = total + marks[i];
            }
            avg = total / 10;
            Array.Sort(marks);
            Console.WriteLine($"Total  marks  is {total}");
            Console.WriteLine($"Average  marks is {avg}");
            Console.WriteLine($"Minimum marks is is {marks[0]}");
            Console.WriteLine($"Maximum marks is is {marks[9]}");

            //ascending order
            Console.WriteLine("Marks in Ascending order");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(marks[i]);
            }


            //descending order
            Console.WriteLine(" Marks in Descending order");
            Array.Reverse(marks);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(marks[i]);
            }

        }
    }
        
}

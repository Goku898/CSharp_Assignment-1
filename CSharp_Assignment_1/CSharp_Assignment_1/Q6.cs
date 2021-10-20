using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the temperature in farenheit ");
            double fah = Convert.ToDouble(Console.ReadLine());
            double cel = (((fah - 32.0)) * (5.0 / 9.0));
            Console.WriteLine($"The temperature in degree celsius is {Math.Round(cel,2)}deg C");
        }
    }
}

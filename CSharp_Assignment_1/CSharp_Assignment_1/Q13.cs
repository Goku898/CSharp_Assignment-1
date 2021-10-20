using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment_1
{
    class Q13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input five numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e= Convert.ToInt32(Console.ReadLine());
            int small = 0;
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        if (a < e)
                            small = a;
                        else
                            small = e;
                    }
                    else
                    {
                        if (d < e)
                            small = d;
                        else
                            small = e;
                    }

                }
                else
                {
                    if (c < d)
                    {
                        if (c < e)
                            small = c;
                        else
                            small = e;
                    }
                    else
                    {
                        if (d < e) small = d;
                        else
                            small = e;
                    }

                }
            }
            else
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        if (b < e)
                            small = b;
                        else
                            small = e;
                    }
                    else
                    {
                        if (d < e)
                            small = d;
                        else
                            small = e;
                    }
                }
                else
                {
                    if (c < d)
                    {
                        if (c < e)
                            small = c;
                        else
                            small = e;
                    }
                    else
                    {
                        if (d < e)
                            small = d;
                        else
                            small = e;
                    }
                }
            }
            Console.WriteLine($"Smallest among {a},{b},{c},{d} and {e} is {small}");
        }
       }
    }

using System;

namespace Set1_Pb15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Numerele nu sunt distincte.");
                return;
            }
            else
            {
                if (a < b && a < c)
                {
                    if (b < c)
                    {
                        Console.WriteLine($"{a}, {b}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{a}, {c}, {b}");
                    }
                }
                else if (b < a && b < c)
                {
                    if (a < c)
                    {
                        Console.WriteLine($"{b}, {a}, {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{b}, {c}, {a}");
                    }
                }
                else
                {
                    if (a < b)
                    {
                        Console.WriteLine($"{c}, {a}, {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{c}, {b}, {a}");
                    }
                }
            }
        }
    }
}

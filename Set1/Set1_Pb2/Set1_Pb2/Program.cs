using System;

namespace Set1_Pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti trei numere pentru o functie de gradul doi");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("Ecuatia este de gradul intai.");
                if (b == 0)
                    Console.WriteLine("Ecuatia nu are solutie");
                else
                {
                    if (c == 0)
                        Console.WriteLine("Solutia ecuatiei este: x=0");
                    else
                    {
                        double x = -c / b;
                        Console.WriteLine($"Solutia ecuatiei este: x= {x}");
                    }
                }

            }
            else
               if (delta < 0)
            {
                Console.WriteLine("Ecuatia nu are solutii reale");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Ecuatia are o singura solutie reala: x ={x} ");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Ecuatia are doua solutii reale: x1 = {x1}, x2 ={x2} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double x;
            if (a == 0)
                Console.WriteLine("Ecuatia nu are solutie");
            else
            {
                if (b == 0)
                    Console.WriteLine("Solutia ecuatiei este: x=0");
                else
                {
                    x = -b / a;
                    Console.WriteLine($"Solutia ecuatiei este: x= {x}");
                }
            }
        }
    }
}

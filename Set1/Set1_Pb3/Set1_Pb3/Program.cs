using System;

namespace Set1_Pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (k == 0)
                Console.WriteLine("Zero nu poate fi divizor");
            else
                if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
                else
                {
                Console.WriteLine($"{n} nu se divide cu {k}");
                }

        }
    }
}

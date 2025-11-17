using System;

namespace Set1_Pb12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti trei numere");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int contor = 0;
            int swap;
            if (a > b)
            {
                swap = a;
                a = b;
                b = swap;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    contor++;
                }

            }
            Console.WriteLine($"Numarul de divizori este: {contor}");

        }
    }
}

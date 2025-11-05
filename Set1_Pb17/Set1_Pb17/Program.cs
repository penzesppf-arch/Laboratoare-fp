using System;

namespace Set1_Pb17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int rest = a % b;
            int x = a;
            int y = b;
            while (rest != 0)
            {
                a = b;
                b = rest;
                rest = a % b;
            }
            int cmmmc = (x * y) / b;
            Console.WriteLine($"Cmmdc este {b} si cmmmc este {cmmmc}");
        }
    }
}

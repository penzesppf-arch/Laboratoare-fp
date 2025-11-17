using System;

namespace Set1_Pb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere POZITIVE:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
                Console.WriteLine("Nu poate fi triunghi.");
            else
                if (a + b > c || a + c > b || b + c > a)
                Console.WriteLine("Poate fi triunghi.");
            else
                Console.WriteLine("Nu poate fi triunghi.");
        }
    }
}

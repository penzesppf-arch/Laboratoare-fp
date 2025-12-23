using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti coeficientii polinomului de la a0 la an, separati prin spatiu:");
            string input = Console.ReadLine();
            double[] coeficienti = input.Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Introduceti valoarea x la care se evalueaza polinomul:");
            double x = double.Parse(Console.ReadLine());
            int n = coeficienti.Length-1;
            double rezultat = coeficienti[n];
            for (int i = n - 1; i >= 0; i--)
            {
                rezultat = rezultat * x + coeficienti[i];
            }
            Console.WriteLine($"Valoarea polinomului la x={x} este: {rezultat}");
        }
    }
}

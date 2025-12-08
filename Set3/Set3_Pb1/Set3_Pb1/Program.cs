using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numere separate prin spatii.");
            string[] v;
            v = Console.ReadLine().Split(' ');
            int s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s = s + int.Parse(v[i]);
            }
            Console.WriteLine($"Suma numerelor este: {s}");

        }
    }
}

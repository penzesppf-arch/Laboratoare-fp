using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere:");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int maxim = int.MinValue;
            int minim = int.MaxValue;
            foreach (string numarStr in numere)
            {
                int numar = int.Parse(numarStr);
                if (numar > maxim)
                {
                    maxim = numar;
                }
                if (numar < minim)
                {
                    minim = numar;
                }
            }
            Console.WriteLine($"Numarul maxim este: {maxim} ,iar cel minim este: {minim}");

        }
    }
}

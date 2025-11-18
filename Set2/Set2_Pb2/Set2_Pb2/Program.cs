using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o secventa de n numere separate prin spatiu:");
            string numere = Console.ReadLine();
            string[] numereArray = numere.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            int nrPozitive = 0;
            int nrNegative = 0;
            int nrNull = 0;
            foreach (string nrString in numereArray)
            {
                if (int.TryParse(nrString, out int nr))
                {
                    if (nr > 0)
                    {
                        nrPozitive++;
                    }
                    else if (nr < 0)
                    {
                        nrNegative++;
                    }
                    else
                    {
                        nrNull++;
                    }
                }
                else
                {
                    Console.WriteLine($"'{nrString}' nu este un numar intreg.");
                }
            }
            Console.WriteLine($"Numere pozitive: {nrPozitive}, numere negative: {nrNegative} si care sunt zero :{nrNull}.");

        }
    }
}

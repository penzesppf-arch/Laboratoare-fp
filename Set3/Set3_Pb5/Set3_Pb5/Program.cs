using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti un sir de {n} numere intregi separate prin spatiu:");
            string sir = Console.ReadLine();
            int[] numere = sir.Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            Console.WriteLine("Introduceti e si k:");
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] rezultat= new int[n+1];
            for (int i = 0; i < n + 1; i++)
            {
                if (i < k)
                {
                    rezultat[i] = numere[i];
                }
                else if (i == k)
                {
                    rezultat[i] = e;
                }
                else
                {
                    rezultat[i] = numere[i - 1];
                }
            }
            Console.WriteLine("Sirul modificat este:");
            for (int i = 0; i < rezultat.Length; i++)
            {
                Console.Write($"{rezultat[i]} ");
            }

        }
    }
}

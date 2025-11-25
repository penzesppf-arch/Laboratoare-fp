using System;
using System.Linq;

namespace Set2_Pb15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            int[] numere = sir.Split(' ')
                              .Select(int.Parse)
                              .ToArray();
            int n = numere.Length;
            bool esteBitonic = true;
            if (n < 3)
            {
                esteBitonic = false;
            }
            else
            {
                int i = 0;
                while (i < n - 1 && numere[i] <= numere[i + 1])
                {
                    i++;
                }
                if (i == 0)
                    esteBitonic = false;
                else
                {
                    int j = i;
                    while (j < n - 1 && numere[j] >= numere[j + 1])
                    {
                        j++;
                    }
                    if (j != n - 1 || j == i)
                        esteBitonic = false;
                }
            }
            if (esteBitonic)
                Console.WriteLine("Sirul este bitonic.");
            else
                Console.WriteLine("Sirul NU este bitonic.");
        }
    }
}

using System;
using System.Linq;

namespace Set3_Pb4
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
            if (numere.Length == 0)
            {
                Console.WriteLine("Sirul este gol.");
                return;
            }
            int min = numere[0], max = numere[0];
            int countMin = 1, countMax = 1;
            for (int i = 1; i < numere.Length; i++)
            {
                int curent = numere[i];
                if (curent < min)
                {
                    min = curent;
                    countMin = 1;
                }
                else if (curent == min)
                {
                    countMin++;
                }
                if (curent > max)
                {
                    max = curent;
                    countMax = 1;
                }
                else if (curent == max)
                {
                    countMax++;
                }

            }
            Console.WriteLine($"Minimul este {min} si apare de {countMin} ori.");
            Console.WriteLine($"Maximul este {max} si apare de {countMax} ori.");

        }
    }
}
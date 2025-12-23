using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            int[] numere = sir.Split(' ').Select(int.Parse).ToArray();
            for (int i = 1; i < numere.Length; i++)
            {
                int cheie = numere[i];
                int j = i - 1;
                while (j >= 0 && numere[j] > cheie)
                {
                    numere[j + 1] = numere[j];
                    j--;
                }
                numere[j + 1] = cheie;
            }
            Console.WriteLine("Sirul sortat este:");
            Console.WriteLine(string.Join(" ", numere));
        }
    }
}

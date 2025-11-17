using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti un numae k:");
            int k = int.Parse(Console.ReadLine());
            int copieN = n;
            int lungime = 0;
            while (copieN != 0)
            {
                lungime++;
                copieN /= 10;
            }
            if (k > lungime)
            {
                Console.WriteLine("k nu poate fi mai mare decat numarul de cifre al numarului n");
            }
            else
            {
                for (int i = 1; i < k; i++)
                {
                    n /= 10;
                }
                int cifra = n % 10;
                Console.WriteLine($"Rezultatul este:{cifra}");

            }
        }
    }
}

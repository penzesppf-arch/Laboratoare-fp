using System;

namespace Set3_Pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string[] vector;
            vector = Console.ReadLine().Split(' ');
            Console.WriteLine("Introduceti un numar k");
            int k = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < vector.Length; i++)
            {
               int v= int.Parse(vector[i]);
                if (v == k)
                {
                    poz = i;
                    break;
                }
            }
            if (poz != -1)
                Console.WriteLine($"Numarul k a fost gasit pe pozitia {poz}.");
            else
                Console.WriteLine("Numarul k NU a fost gasit pe pozitia.");

        }
    }
}

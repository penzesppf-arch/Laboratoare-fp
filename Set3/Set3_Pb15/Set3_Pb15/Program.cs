using System;

namespace Set3_Pb15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere separate prin spatii:");
            string sir = Console.ReadLine();
            int[] numere = Array.ConvertAll(sir.Split(' '), int.Parse);
            Array.Sort(numere);
            int k = 0;
            for (int i = 1; i < numere.Length; i++)
            {
                if (numere[i] != numere[k])
                {
                    k++;
                    numere[k] = numere[i];
                }
            }
            int dimensiune = k + 1;
            Console.WriteLine("Sirul fara duplicate este:");
            for (int i = 0; i < dimensiune; i++)
            { Console.Write(numere[i] + " "); }
        }
    }
}

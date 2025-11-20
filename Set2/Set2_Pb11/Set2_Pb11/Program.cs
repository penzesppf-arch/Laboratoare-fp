using System;

namespace Set2_Pb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un si de numere:");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(' ');
            int suma = 0;
            foreach (string numar in numere)
            {
                suma += invers(int.Parse(numar));
            }
            Console.WriteLine($"Suma numerelor inversate este: {suma}");
        }

        static int invers(int n)
        {
            int inversat = 0;
            while (n != 0)
            {
                int cifra = n % 10;
                inversat = inversat * 10 + cifra;
                n /= 10;
            }
            return inversat;
        }
    }
}

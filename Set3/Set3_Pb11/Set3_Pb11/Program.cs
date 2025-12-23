using System;

namespace Set3_Pb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar :");
            int n = int.Parse(Console.ReadLine());
            bool[] isNotPrime = new bool[n + 1];
            isNotPrime[0] = isNotPrime[1] = true;
            for (int p = 2; p * p <= n; p++)
            {
                if (isNotPrime[p] == false)
                {
                    for (int i = p * p; i <= n; i += p)
                    { isNotPrime[i] = true; }
                }
            }

            Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt:");
            for (int i = 2; i <= n; i++)
            {
                if (isNotPrime[i] == false)
                { Console.Write(i + " "); }
            }
        }
    }
}

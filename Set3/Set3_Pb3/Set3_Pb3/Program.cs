using System;

namespace Set3_Pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere separate prin spatii:");
            string[] input = Console.ReadLine().Split(' ');
            int[] vector = new int[input.Length];
            for (int k = 0; k < input.Length; k++)
            {
                vector[k] = int.Parse(input[k]);
            }
            int n = vector.Length;
            if (n == 0) return;
            int minPoz, maxPoz;
            int i;
            if (n % 2 == 0)
            {
                if (vector[0] < vector[1])
                {
                    minPoz = 0;
                    maxPoz = 1;
                }
                else
                {
                    minPoz = 1;
                    maxPoz = 0;
                }
                i = 2;
            }
            else
            {
                minPoz = 0;
                maxPoz = 0;
                i = 1;
            }
            while (i < n - 1)
            {
                if (vector[i] > vector[i + 1])
                {
                    if (vector[i] > vector[maxPoz])
                    {
                        maxPoz = i;
                    }
                    maxPoz = i;
                    if (vector[i + 1] < vector[minPoz])
                    {
                        minPoz = i + 1;
                    }
                }
                else
                {
                    if (vector[i + 1] > vector[maxPoz])
                    {
                        maxPoz = i + 1;
                    }
                    if (vector[i] < vector[minPoz])
                    {
                        minPoz = i;
                    }
                }
                i += 2;
            }
            Console.WriteLine($"Pozitia minimului:{minPoz}");
            Console.WriteLine($"Pozitia maximului:{maxPoz}");

        }
    }
}

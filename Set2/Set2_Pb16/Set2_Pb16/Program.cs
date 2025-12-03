using System;
using System.Linq;

namespace Set2_Pb16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            int[] Numere = sir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
            int n = Numere.Length;
            bool esteBitonicRotita = false;
            for (int i = 0; i < n; i++)
            {
                if (VerificaBitonic(Numere))
                {
                    esteBitonicRotita = true;
                    Console.WriteLine($"Secventa este bitonic rotita");
                    break;
                }
                RotesteStanga(Numere);
            }
            if (!esteBitonicRotita)
                Console.WriteLine("Secventa nu este bitonic rotita");
        }
        static bool VerificaBitonic(int[] arr)
        {
            int n = arr.Length;
            if (n < 3)
                return false;
            int i = 0;
            while (i < n - 1 && arr[i] < arr[i + 1])
                i++;
            if (i == 0)
                return false;
            int j = i;
            while (j < n - 1 && arr[j] >= arr[j + 1])
                j++;
            if (j != n - 1 || j == i)
                return false;
            return true;
        }
        static void RotesteStanga(int[] arr)
        {
            if (arr.Length <= 1)
                return;
            int primulElement = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = primulElement;
        }
    }
}

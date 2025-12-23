using System;

namespace Set3_Pb19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere s separate prin spatii:");
            string input = Console.ReadLine();
            int[] s = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine("Introduceti un sir de numere p separate prin spatii:");
            string cauta = Console.ReadLine();
            int[] p = Array.ConvertAll(cauta.Split(' '), int.Parse);

            int numarAparitii = 0;
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                bool estePotrivire = true;

                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        estePotrivire = false;
                        break;
                    }
                }

                if (estePotrivire)
                {
                    numarAparitii++;
                }
            }

            Console.WriteLine($"Vectorul p apare in s de {numarAparitii} ori.");
        }
    }
}

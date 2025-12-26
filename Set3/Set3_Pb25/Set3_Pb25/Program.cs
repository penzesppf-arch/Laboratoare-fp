using System;
using System.Linq;

namespace Set3_Pb25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceți elementele primului vector (v1) - SORTATE:");
            int[] v1 = CitesteVector();

            Console.WriteLine("Introduceți elementele celui de-al doilea vector (v2) - SORTATE:");
            int[] v2 = CitesteVector();
            int[] v3 = Interclaseaza(v1, v2);
            Console.WriteLine($"Vectorul rezultat interclasat:");
            Console.WriteLine(string.Join(" ", v3));
        }

        static int[] Interclaseaza(int[] v1, int[] v2)
        {
            int n = v1.Length;
            int m = v2.Length;
            int[] rezultat = new int[n + m]; 

            int i = 0, j = 0, k = 0;

            while (i < n && j < m)
            {
                if (v1[i] <= v2[j])
                {
                    rezultat[k++] = v1[i++];
                }
                else
                {
                    rezultat[k++] = v2[j++];
                }
            }

            while (i < n)
            {
                rezultat[k++] = v1[i++];
            }

            while (j < m)
            {
                rezultat[k++] = v2[j++];
            }

            return rezultat;
        }

        static int[] CitesteVector()
        {
            string input = Console.ReadLine();
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
        }
    }
}
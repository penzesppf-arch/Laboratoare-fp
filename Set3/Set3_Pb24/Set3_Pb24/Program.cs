using System;
using System.Linq;

namespace Set3_Pb24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti primul vector binar (ex: 1 0 1 1 0...):");
            int[] v1 = CitesteVectorBinar();

            Console.WriteLine("Introduceti al doilea vector binar (de aceeasi lungime):");
            int[] v2 = CitesteVectorBinar();

            int n = Math.Min(v1.Length, v2.Length);

            int[] reuniune = new int[n];
            for (int i = 0; i < n; i++)
                reuniune[i] = (v1[i] == 1 || v2[i] == 1) ? 1 : 0;

            int[] intersectie = new int[n];
            for (int i = 0; i < n; i++)
                intersectie[i] = (v1[i] == 1 && v2[i] == 1) ? 1 : 0;

            int[] diferentaV1V2 = new int[n];
            for (int i = 0; i < n; i++)
                diferentaV1V2[i] = (v1[i] == 1 && v2[i] == 0) ? 1 : 0;

            int[] diferentaV2V1 = new int[n];
            for (int i = 0; i < n; i++)
                diferentaV2V1[i] = (v2[i] == 1 && v1[i] == 0) ? 1 : 0;


            AfiseazaVector("Reuniune:    ", reuniune);
            AfiseazaVector("Intersecție: ", intersectie);
            AfiseazaVector("Diferență V1-V2: ", diferentaV1V2);
            AfiseazaVector("Diferență V2-V1: ", diferentaV2V1);
        }

        static int[] CitesteVectorBinar() =>
            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        static void AfiseazaVector(string mesaj, int[] v) =>
            Console.WriteLine(mesaj + string.Join(" ", v));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceți elementele primului vector (v1) - SORTATE, separate prin spațiu:");
            int[] v1 = CitesteVector();

            Console.WriteLine("Introduceți elementele celui de-al doilea vector (v2) - SORTATE, separate prin spațiu:");
            int[] v2 = CitesteVector();
            Console.WriteLine("\n--- REZULTATE ---");

            Afiseaza("Reuniune (v1 ∪ v2):", Reuniune(v1, v2));
            Afiseaza("Intersecție (v1 ∩ v2):", Intersectie(v1, v2));
            Afiseaza("Diferență (v1 - v2):", Diferenta(v1, v2));
            Afiseaza("Diferență (v2 - v1):", Diferenta(v2, v1));
        }

        static int[] CitesteVector()
        {
            string input = Console.ReadLine() ;
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
        }

        // --- REUNIUNEA ---
        static List<int> Reuniune(int[] v1, int[] v2)
        {
            List<int> rez = new List<int>();
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j]) rez.Add(v1[i++]);
                else if (v1[i] > v2[j]) rez.Add(v2[j++]);
                else { rez.Add(v1[i]); i++; j++; }
            }
            while (i < v1.Length) rez.Add(v1[i++]);
            while (j < v2.Length) rez.Add(v2[j++]);
            return rez;
        }

        // --- INTERSECȚIA ---
        static List<int> Intersectie(int[] v1, int[] v2)
        {
            List<int> rez = new List<int>();
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j]) i++;
                else if (v1[i] > v2[j]) j++;
                else { rez.Add(v1[i]); i++; j++; }
            }
            return rez;
        }

        // --- DIFERENȚA ---
        static List<int> Diferenta(int[] v1, int[] v2)
        {
            List<int> rez = new List<int>();
            int i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j]) rez.Add(v1[i++]);
                else if (v1[i] > v2[j]) j++;
                else { i++; j++; }
            }
            while (i < v1.Length) rez.Add(v1[i++]);
            return rez;
        }

        static void Afiseaza(string mesaj, List<int> lista)
        {
            Console.Write($"{mesaj,-25} ");
            if (lista.Count == 0) Console.WriteLine("∅ (mulțime vidă)");
            else Console.WriteLine("{ " + string.Join(", ", lista) + " }");
        }
    }
}

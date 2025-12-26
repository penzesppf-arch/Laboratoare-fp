using System;
using System.Linq;

namespace Set3_Pb30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti elementele vectorului E (separate prin spatiu):");
            int[] E = CitesteVector();
            Console.WriteLine("Introduceti ponderile vectorului W (separate prin spatiu, aceeasi lungime):");
            int[] W = CitesteVector();

            if (E.Length != W.Length || E.Length == 0)
            {
                Console.WriteLine("Eroare: Lungimile vectorilor nu corespund sau sunt goale.");
                return;
            }

            Console.WriteLine("\nInainte de sortare:");
            Afiseaza(E, W);
            var perechiSortate = E.Select((valoare, index) => new
            {
                Element = valoare,
                Pondere = W[index]
            })
                .OrderBy(x => x.Element)           
                .ThenByDescending(x => x.Pondere)  
                .ToList();

            for (int i = 0; i < E.Length; i++)
            {
                E[i] = perechiSortate[i].Element;
                W[i] = perechiSortate[i].Pondere;
            }

            Console.WriteLine("\nDupa sortare:");
            Afiseaza(E, W);
        }

        static int[] CitesteVector()
        {
            string input = Console.ReadLine() ?? "";
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
        }

        // Metodă utilitară pentru afișare
        static void Afiseaza(int[] E, int[] W)
        {
            for (int i = 0; i < E.Length; i++)
                Console.WriteLine($"E[{i}]: {E[i]}, W[{i}]: {W[i]}");
        }
    }
}


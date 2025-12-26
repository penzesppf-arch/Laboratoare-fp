using System;
using System.Collections.Generic;
using System.Linq;

namespace Set3_Pb22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string input1 = Console.ReadLine();
            int[] A = input1.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Introduceti un sir de numere");
            string input2 = Console.ReadLine();
            int[] B = input2.Split(' ').Select(int.Parse).ToArray();
            HashSet<int> setA = new HashSet<int>(A);
            HashSet<int> setB = new HashSet<int>(B);
            HashSet<int> intersectie = new HashSet<int>(setA);
            intersectie.IntersectWith(setB);
            AfiseazaMultime("Intersectie (A ∩ B):", intersectie);
            HashSet<int> reuniune = new HashSet<int>(setA);
            reuniune.UnionWith(setB);
            AfiseazaMultime("Reuniune (A ∪ B):", reuniune);
            HashSet<int> diferentaAB = new HashSet<int>(setA);
            diferentaAB.ExceptWith(setB);
            AfiseazaMultime("Diferență (A - B)", diferentaAB);
            HashSet<int> diferentaBA = new HashSet<int>(setB);
            diferentaBA.ExceptWith(setA);
            AfiseazaMultime("Diferență (B - A)", diferentaBA);

        }
        static void AfiseazaMultime(string mesaj, HashSet<int> multime)
        {
            Console.WriteLine(mesaj);
            foreach (var item in multime)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
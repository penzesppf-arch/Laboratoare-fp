using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti m si n: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n; 
            parteFract = m % n;
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
    }
    }


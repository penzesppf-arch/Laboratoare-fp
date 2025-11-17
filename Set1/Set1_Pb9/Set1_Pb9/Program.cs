using System;
using System.Collections.Generic;

namespace Set1_Pb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar pozitiv ");
            int n = int.Parse(Console.ReadLine());
            List<int> divizori = new List<int>();
            for (int d = 1; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    divizori.Add(d);
                    if (d != n / d)
                        divizori.Add(n / d);
                }
            }
            divizori.Sort();
            Console.WriteLine($"Divizorii lui {n} sunt :");
            Console.WriteLine(string.Join(" ", divizori));
        }
        
    }
}

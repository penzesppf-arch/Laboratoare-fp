using System;
using System.Collections.Generic;

namespace Set1_Pb19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            string n = Console.ReadLine();
            HashSet<char> cifre = new HashSet<char>();
            foreach(char c in n)
            {
                if (char.IsDigit(c))
                    cifre.Add(c);
            }
            if (cifre.Count == 2)
                Console.WriteLine("Numarul este format doar din 2 cifre");
            else
                Console.WriteLine("Numarul NU este format doar din 2 cifre");

        }
    }
}

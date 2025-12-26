using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere:");
            string input1 = Console.ReadLine();
            int[] sir1 = input1.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Introduceti inca un sir de numere:");
            string input2 = Console.ReadLine();
            int[] sir2 = input2.Split(' ').Select(int.Parse).ToArray();
            int rezultat = ComparaLexicografic(sir1, sir2);
            if (rezultat < 0)
                Console.WriteLine("Primul sir este mai mic decat al doilea.");
            else if (rezultat > 0)
                Console.WriteLine("Primul sir este mai mare decat al doilea.");
            else
                Console.WriteLine("Cele doua siruri sunt egale.");

        }
        static int ComparaLexicografic(int[] sir1, int[] sir2)
        {
            int minLength = Math.Min(sir1.Length, sir2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (sir1[i] < sir2[i])
                    return -1;
                else if (sir1[i] > sir2[i])
                    return 1;
            }
            if (sir1.Length < sir2.Length)
                return -1;
            else if (sir1.Length > sir2.Length)
                return 1;
            else
                return 0;
        }
    }
}

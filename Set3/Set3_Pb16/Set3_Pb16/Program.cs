using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere numere:");
            string sir = Console.ReadLine();
            int[] numere = sir.Split(' ').Select(int.Parse).ToArray();
            int rezultat = numere[0];
            for (int i = 1; i < numere.Length; i++)
            {
                rezultat = CMMDC(rezultat, numere[i]);
            }
            Console.WriteLine($"Cel mai mare divizor comun este:{rezultat}.");

        }
        static int CMMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine ("Introduceti un sir de numere:");
            string sir= Console.ReadLine();
            int[] numere = sir.Split(' ').Select(int.Parse).ToArray();
            int temp;
            for (int i = 0; i < numere.Length / 2; i++) 
            {
            temp = numere[i];
                numere[i] = numere[numere.Length - 1 - i];
                numere[numere.Length - 1 - i] = temp;

            }
            Console.WriteLine("Sirul inversat este:");
            Console.WriteLine(string.Join(" ", numere));
        }
    }
}

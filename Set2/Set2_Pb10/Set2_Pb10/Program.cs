using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(' ');
            int count = 0;
            for (int i = 0; i < numere.Length - 1; i++)
            {
                if (numere[i] == numere[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} numere consecutive sunt egale.");
        }
    }
}

using System;

namespace Set2_Pb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un sir de numere si un numar a");
            string sir = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            string[] numere = sir.Split(' ');
            int poz = Array.IndexOf(numere, a.ToString());
            if (poz != -1)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {poz}");
            }
            else 
                Console.WriteLine($" -1 ");
        }

    }
}

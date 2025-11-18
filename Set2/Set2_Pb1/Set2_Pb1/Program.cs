using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n si o secventa de n numere:");
            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = 0; i < n; i++)
            {
              int nr = int.Parse(Console.ReadLine());
                if(nr % 2 == 0)
                    contor++;
            } 
            Console.WriteLine($"Numarul de numere pare este: {contor}");
        }   
    }
}

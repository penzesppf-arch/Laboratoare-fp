using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(' ');
            int count = 0;
            if (numere.Length <= 1)
            {
                Console.WriteLine("Sirul este o secventa crescatoare rotita.");
                return;
            }
            int[] sirNumere= new int[numere.Length];
            for (int i = 0; i < numere.Length; i++)
            {
                sirNumere[i] = int.Parse(numere[i]);
            }
            for (int i = 0; i < sirNumere.Length - 1; i++)
            { 
                if (sirNumere[i] > sirNumere[i + 1])
                    count++;
            }
            if(sirNumere[sirNumere.Length - 1] > sirNumere[0])
                count++;

            if (count <= 1)
                Console.WriteLine("Sirul este o secventa crescatoare rotita.");
            else
                Console.WriteLine("Sirul NU este o secventa crescatoare rotita.");
        }
    }
}

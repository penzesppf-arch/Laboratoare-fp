using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceți elementele vectorului separate prin spațiu:");
            int[] v = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray() ?? new int[0];

            if (v.Length == 0) return;
            int candidat = 0;
            int contor = 0;
            foreach (int x in v)
            {
                if (contor == 0)
                {
                    candidat = x;
                    contor = 1;
                }
                else if (x == candidat)
                {
                    contor++;
                }
                else
                {
                    contor--;
                }
            }

            int aparitii = 0;
            foreach (int x in v)
            {
                if (x == candidat) aparitii++;
            }

            if (aparitii > v.Length / 2)
            {
                Console.WriteLine($"Elementul majoritate este: {candidat}");
            }
            else
            {
                Console.WriteLine("<nu exista>");
            }
        }
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți primul șirag (ex: ANN): ");
            string s1 = Console.ReadLine()?.ToUpper() ?? "";

            Console.Write("Introduceți al doilea șirag (ex: AN): ");
            string s2 = Console.ReadLine()?.ToUpper() ?? "";

            int n = s1.Length;
            int m = s2.Length;
            int numarSuprapuneri = 0;

            for (int offset = -m + 1; offset < n; offset++)
            {
                bool esteValida = true;
                bool existaSuprapunere = false;

                for (int i = 0; i < n; i++)
                {
                    int j = i - offset; 
                    if (j >= 0 && j < m)
                    {
                        existaSuprapunere = true;
                        if (s1[i] != s2[j])
                        {
                            esteValida = false; 
                            break;
                        }
                    }
                }

                if (esteValida && existaSuprapunere)
                {
                    numarSuprapuneri++;
                }
            }

            Console.WriteLine($"\nRezultat: Există {numarSuprapuneri} suprapuneri valide.");
        }
    }
}
    
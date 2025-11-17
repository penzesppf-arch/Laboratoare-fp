using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gandeste te la un numar intre 1 si 1024");
            Console.WriteLine("Eu voi incerca sa il ghicesc.Apasa Enter cand esti gata...");
            Console.ReadLine();
            int min = 1;
            int max = 1024;
            int incercari = 0;
            bool nrGhicit = false;
            while (!nrGhicit)
            {
                incercari++;
                int ghicire = (min + max) / 2;
                Console.WriteLine($"Numarul tau este {ghicire} ?");
                Console.WriteLine("Raspunde cu: mai mare / mai mic / corect");
                string raspuns = Console.ReadLine().ToLower();
                if (raspuns == "corect")
                {
                    nrGhicit = true;
                    Console.WriteLine($"Yay! Am ghicit numarul tau in {incercari} incercari.");
                }
                else if (raspuns == "mai mare")
                {
                    min = ghicire + 1;
                }
                else if (raspuns == "mai mic")
                {
                    max = ghicire - 1;
                }
                else
                {
                    Console.WriteLine("Raspuns invalid. Te rog raspunde cu: mai mare / mai mic / corect");
                }
            }
        }
    }
}

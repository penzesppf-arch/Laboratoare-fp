using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doi ani");
            int an1 = int.Parse(Console.ReadLine());
            int an2 = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int an = an1; an <= an2; an++)
            {
                if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
                {
                    contor++;
                }
               
            } 
            Console.WriteLine($"Numarul de ani bisecti intre {an1} si {an2} este: {contor}");
        }
    }
}

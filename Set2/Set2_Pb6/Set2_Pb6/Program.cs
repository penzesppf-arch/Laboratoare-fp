
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere:");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool esteCrescator = true;
            for (int i = 1; i < numere.Length; i++)
            {
                if (int.Parse(numere[i]) < int.Parse(numere[i - 1]))
                {
                    esteCrescator = false;
                    break;
                }
            }
            if (esteCrescator)
            {
                Console.WriteLine("Sirul este crescator.");
            }
            else
            {
                Console.WriteLine("Sirul nu este crescator.");
            }
        }
    }
}

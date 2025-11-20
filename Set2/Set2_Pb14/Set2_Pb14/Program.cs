using System;
using System.Linq;

namespace Set2_Pb14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries);
            if (numere.Length <= 1)
            {
                Console.WriteLine("Sirul este o secventa monoton rotita.");
                return;
            }
            int[] sirNumere = numere.Select(int.Parse).ToArray();
            int n = sirNumere.Length;
            bool esteMonoton = false;
            int countCrescator = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (sirNumere[i] > sirNumere[i + 1])
                    countCrescator++;
            }
            if (sirNumere[n - 1] > sirNumere[0])
                countCrescator++;

            if (countCrescator <= 1)
                esteMonoton = true;
            if (!esteMonoton)
            {
                int countDescrescator = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (sirNumere[i] < sirNumere[i + 1])
                        countDescrescator++;
                }
                if (sirNumere[n - 1] < sirNumere[0])
                    countDescrescator++;
                if (countDescrescator <= 1)
                    esteMonoton = true;
            }
            if (esteMonoton)

                Console.WriteLine("Sirul este o secventa monoton rotita.");
            else
                Console.WriteLine("Sirul NU este o secventa monoton rotita.");
        }
    }
}

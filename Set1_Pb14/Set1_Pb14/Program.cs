using System;

namespace Set1_Pb14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un nr");
            int n = int.Parse(Console.ReadLine());
            bool pal(int nr)
            {
                int oglindit = 0, copie = nr;
                while (copie != 0)
                {
                    oglindit = oglindit * 10 + copie % 10;
                    copie /= 10;
                }
                return oglindit == nr;
            }
            if (pal(n))
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }
    }
}

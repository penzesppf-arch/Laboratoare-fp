using System;
using System.Linq;

namespace Set3_Pb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            int[] numere = sir.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            Console.WriteLine("Introduceti un nr :");
            int k = int.Parse(Console.ReadLine());
            int [] rezultat= new int[numere.Length - 1];
          int j = 0;
            for (int i = 0; i < numere.Length; i++)
            {
                if (i != k)
                {
                    rezultat[j]=numere[i];
                    j++;
                }
            }
            Console.WriteLine("Sirul rezultat este:");
            Console.WriteLine(string.Join(" ", rezultat));
        }
    }
}

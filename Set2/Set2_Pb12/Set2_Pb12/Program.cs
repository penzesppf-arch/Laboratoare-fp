using System;

namespace Set2_Pb12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un cir de numere delimitate de 0");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            bool inGroup = false;
            int[] secventa;
            try
            {
                secventa = Array.ConvertAll(numere, int.Parse);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid. Asigurati-va ca introduceti doar numere intregi separate prin spatii.");
                return;
            }
            for (int i = 0; i < numere.Length; i++)
            {
                if (secventa[i] == 0)
                {
                    break;
                }
                if (i > 0 && secventa[i] == secventa[i - 1] + 1)
                {
                    if (!inGroup)
                    {
                        count++;
                        inGroup = true;
                    }
                }
                else
                {
                    inGroup = false;
                }
            }


            Console.WriteLine($"Exista {count} grupuri de numere consecutive.");
        }
    }
}

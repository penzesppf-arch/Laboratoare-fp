using System;

namespace Set2_Pb17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o secventa de 0 si 1");
            Console.WriteLine("Exemplu: 1 0 1 0 0 1");
            string input = Console.ReadLine();
            string[] elemente = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int currentDepth = 0;
            int maxDepth = 0;
            bool esteValid = true;
            foreach (string element in elemente)
            {
                int valoare = int.Parse(element);
                if (valoare == 0)
                {
                    currentDepth++;
                    if (currentDepth > maxDepth)
                        maxDepth = currentDepth;
                }
                else if (valoare == 1)

                    currentDepth--;
                if (currentDepth < 0)
                {
                    esteValid = false;
                    break;
                }
            }
            if (esteValid && currentDepth == 0)
            {
                Console.WriteLine("Secvente este CORECTA");
                                Console.WriteLine($"Nivelul maxim de incuibare este: {maxDepth}");
            }
            else
            {
                Console.WriteLine("Secventa este INCORECTA.");
            }
        }
    }
}

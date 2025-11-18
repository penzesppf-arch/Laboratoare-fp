using System;

namespace Set2_Pb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(' ');
            int[] v=new int[numere.Length];
            for (int i = 0; i < numere.Length; i++)
            {
                v[i] = int.Parse(numere[i]);
            }
            bool esteCrescator = true;
            bool esteDescrescator = true;
            for (int i = 0; i < numere.Length -1; i++)
            {
                if (v[i] < v[i + 1])
                {
                    esteDescrescator = false;
                }
                if(v[i] > v[i + 1])
                {
                    esteCrescator = false;
                }

            }
            if (esteCrescator || esteDescrescator)
            {
                Console.WriteLine("Secventa este monotona");
            }
            else
            { 
                Console.WriteLine("Secventa nu este monotona");
            }
        }
    }
}


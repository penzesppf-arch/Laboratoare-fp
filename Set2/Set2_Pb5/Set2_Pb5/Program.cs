using System;

namespace Set2_Pb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere separate prin spatii:");
            string sir = Console.ReadLine();
            string[] numere = sir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < numere.Length; i++)
            {
                int num;
                if (int.TryParse(numere[i], out num))
                {
                    if (num == i)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Atatea nr coincid cu pozitia lor : {count}.");
        }
    }
}

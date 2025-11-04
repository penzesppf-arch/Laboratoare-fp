using System;

namespace Set1_Pb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int nr = int.Parse(Console.ReadLine());
            bool estePrim(int n)
            {
                if (n <= 1) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;

                int limit = (int)Math.Sqrt(n);
                for (int i = 3; i <= limit; i += 2)
                {
                    if (n % i == 0) return false;
                }

                return true;
            }
            if (estePrim(nr))
            {
                Console.WriteLine("Numarul este prim.");
            }
            else
            {
                Console.WriteLine("Numarul nu este prim.");
            }
        }
    }
}

using System;

namespace Set1_Pb18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            int putere = 0;
            int divizor = 2;
            while (n > 1)
            {
                if (n % divizor == 0)
                {
                    putere++;
                    n /= divizor;
                }
                else
                {
                    if (putere > 0)
                    {
                        Console.Write($"{divizor} ^ {putere} * ");
                    }
                    divizor++;
                    putere = 0;
                }
            }
            if (putere > 0)
            {
                Console.Write($"{divizor} ^ {putere}");
            }
            
        }
    }
}

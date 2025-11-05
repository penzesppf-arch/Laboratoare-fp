using System;

namespace Set1_Pb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int cifra;
            if (n == 0)
                Console.WriteLine("0");
            else
                while (n != 0)
                {
                    cifra = n % 10;
                    Console.WriteLine(cifra);
                    n = n / 10;
                }
        }
    }
}

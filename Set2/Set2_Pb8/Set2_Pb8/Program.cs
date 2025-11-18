using System;

namespace Set2_Pb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intruduceti un numar");
            int n = int.Parse(Console.ReadLine());
            long a = 0, b = 1, c;
            for (int i = 2; i <= n; i++)
            {
                
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(b);
        }
    }
}

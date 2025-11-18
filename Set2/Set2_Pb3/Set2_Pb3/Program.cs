using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intrudoceti un numar:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int produs = 1;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma este: {suma} si produsul este : {produs}");
        }
    }
}

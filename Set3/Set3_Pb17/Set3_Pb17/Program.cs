using System;

namespace Set3_Pb17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n si o baza b");
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string rezultat= " ";
            if (b < 0 || b > 16)
            {
                Console.WriteLine("Baza invalida");
            }
            else 
            {
                while (n != 0)
                { 
                int cifra = n % b;
                    rezultat=CifInBaza(cifra)+ rezultat;
                    n/=b;
                }
            }
            Console.WriteLine($"Numarul in baza {b} este: {rezultat}");
        }
        static char CifInBaza (int cifra)
        {
            if (cifra >= 0 && cifra <= 9)
            {
                return (char)(cifra + '0');
            }
            else
            {
                return (char)(cifra - 10 + 'A');
            }
        }
    }
}

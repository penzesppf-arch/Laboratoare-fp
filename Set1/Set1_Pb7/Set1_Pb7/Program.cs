using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int swap=a;
            a = b;  
            b = swap;
            Console.WriteLine($"Dupa interschimbare: {a} , {b}");

        }
    }
}

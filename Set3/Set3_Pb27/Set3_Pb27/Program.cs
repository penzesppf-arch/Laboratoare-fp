using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere:");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Introduceti un index:");
            int index = int.Parse(Console.ReadLine());
            Array.Sort(numbers);
            Console.WriteLine($"Valoarea la indexul {index} este {numbers[index]}");
        }
    }
}

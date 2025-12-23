using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere separate prin spatii:");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[count];
                    numbers[count] = temp;
                    count++;
                }
            }
            Console.WriteLine("Sirul dupa mutarea zerourilor la final:");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere separate prin spatii:");
            string input = Console.ReadLine();
            int[] numbers =input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Introduceti un numar k:");
            int k= int.Parse(Console.ReadLine());
            k %= numbers.Length;
            if(k>0)
            {
                Reverse(numbers, 0, k-1);
                Reverse(numbers, k, numbers.Length - 1);
                Reverse(numbers, 0, numbers.Length-1);
            }
            Console.WriteLine("Sirul dupa rotire este:");
            Console.WriteLine(string.Join(" ", numbers));

        }
        static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}

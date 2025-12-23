
using System;

namespace Set3_Pb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un  sir de numere separate printr-un spatiu:");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length - 1] = temp;
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

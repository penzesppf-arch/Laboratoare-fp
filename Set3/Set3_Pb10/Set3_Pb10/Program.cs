using System;

namespace Set3_Pb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un sir de numere CRESCATOARE:");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine("Introduceti un numar:");
            int k = int.Parse(Console.ReadLine());
            int pozitie = BinarySearchManual(numbers, k);
            Console.WriteLine($"Pozitia numarului {k} este {pozitie}");
        }
        static int BinarySearchManual(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1; 
        }
    }
}

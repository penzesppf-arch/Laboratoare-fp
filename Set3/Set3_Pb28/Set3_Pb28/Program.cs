using System;
using System.Linq;

namespace Set3_Pb28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceți elementele vectorului separate prin spațiu:");
            string input = Console.ReadLine() ;
            int[] v = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            if (v.Length == 0)
            {
                Console.WriteLine("Vectorul este gol.");
                return;
            }

            QuickSort(v, 0, v.Length - 1);
            Console.WriteLine("Vector sortat: " + string.Join(" ", v));
        }

        static void QuickSort(int[] arr, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int indexPivot = Partitionare(arr, stanga, dreapta);
                QuickSort(arr, stanga, indexPivot - 1);
                QuickSort(arr, indexPivot + 1, dreapta);
            }
        }

        static int Partitionare(int[] arr, int stanga, int dreapta)
        {
            int pivot = arr[dreapta];
            int i = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Interchimba(arr, i, j);
                }
            }
            Interchimba(arr, i + 1, dreapta);
            return i + 1;
        }
        static void Interchimba(int[] arr, int a, int b)
        {
            int aux = arr[a];
            arr[a] = arr[b];
            arr[b] = aux;

        }
    }
}

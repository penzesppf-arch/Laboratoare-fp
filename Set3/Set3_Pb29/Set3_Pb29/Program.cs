using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceți elementele vectorului separate prin spațiu:");
            string input = Console.ReadLine();
            int[] v = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            if (v.Length == 0) return;

           
            MergeSort(v, 0, v.Length - 1);
            Console.WriteLine("Vector sortat prin MergeSort:");
            Console.WriteLine(string.Join(" ", v));
        }

        static void MergeSort(int[] arr, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;

               
                MergeSort(arr, stanga, mijloc);
                MergeSort(arr, mijloc + 1, dreapta);

                Interclaseaza(arr, stanga, mijloc, dreapta);
            }
        }

        static void Interclaseaza(int[] arr, int stanga, int mijloc, int dreapta)
        {
            int n1 = mijloc - stanga + 1;
            int n2 = dreapta - mijloc;
            int[] stangaArray = new int[n1];
            int[] dreaptaArray = new int[n2];

            Array.Copy(arr, stanga, stangaArray, 0, n1);
            Array.Copy(arr, mijloc + 1, dreaptaArray, 0, n2);

            int i = 0, j = 0;
            int k = stanga;

            while (i < n1 && j < n2)
            {
                if (stangaArray[i] <= dreaptaArray[j])
                {
                    arr[k] = stangaArray[i];
                    i++;
                }
                else
                {
                    arr[k] = dreaptaArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1) arr[k++] = stangaArray[i++];
            while (j < n2) arr[k++] = dreaptaArray[j++];
        }
    }
}
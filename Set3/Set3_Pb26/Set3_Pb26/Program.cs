using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Pb26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar mare:");
            int[] num1 = Console.ReadLine().Select(c => c - '0').Reverse().ToArray();

            Console.WriteLine("Introduceti al doilea numar mare:");
            int[] num2 = Console.ReadLine().Select(c => c - '0').Reverse().ToArray();

            Console.WriteLine("\nSuma: " + string.Join("", Suma(num1, num2).Reverse()));
            Console.WriteLine("Diferenta: " + string.Join("", Diferenta(num1, num2).Reverse()));
            Console.WriteLine("Produs: " + string.Join("", Produs(num1, num2).Reverse()));
        }

        // --- SUMA ---
        static int[] Suma(int[] a, int[] b)
        {
            List<int> res = new List<int>();
            int transport = 0, i = 0;
            while (i < a.Length || i < b.Length || transport > 0)
            {
                int s = transport + (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0);
                res.Add(s % 10);
                transport = s / 10;
                i++;
            }
            return res.ToArray();
        }

        // --- DIFERENȚA (Presupunem a >= b) ---
        static int[] Diferenta(int[] a, int[] b)
        {
            List<int> res = new List<int>();
            int imprumut = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int scaderi = a[i] - imprumut - (i < b.Length ? b[i] : 0);
                if (scaderi < 0) { scaderi += 10; imprumut = 1; }
                else { imprumut = 0; }
                res.Add(scaderi);
            }
            while (res.Count > 1 && res.Last() == 0) res.RemoveAt(res.Count - 1);
            return res.ToArray();
        }

        // --- PRODUSUL ---
        static int[] Produs(int[] a, int[] b)
        {
            int[] res = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                int transport = 0;
                for (int j = 0; j < b.Length || transport > 0; j++)
                {
                    long curent = res[i + j] + (long)a[i] * (j < b.Length ? b[j] : 0) + transport;
                    res[i + j] = (int)(curent % 10);
                    transport = (int)(curent / 10);
                }
            }
            var lista = res.ToList();
            while (lista.Count > 1 && lista.Last() == 0) lista.RemoveAt(lista.Count - 1);
            return lista.ToArray();
        }
    }

}
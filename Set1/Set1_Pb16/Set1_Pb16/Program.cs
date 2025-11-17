using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Pb16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 5 numere:");
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            for(int pass=0;pass<4; pass++)
            {
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
                if (b > c)
                {
                    int temp = b;
                    b = c;
                    c = temp;
                }
                if (c > d)
                {
                    int temp = c;
                    c = d;
                    d = temp;
                }
                if (d > e)
                {
                    int temp = d;
                    d = e;
                    e = temp;
                }
            }
            Console.WriteLine("Numerele ordonate crescator sunt:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

        }
    }
}

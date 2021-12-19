using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            //declararea numerelor
            double a;
            int x = 0;
            //initializarea numerelor
            a = double.Parse(Console.ReadLine());
            //crearea unui vector pentru retinerea divizorilor
            int[] v=new int[201];
            for (int i = 1; i <= a ; i++)
            {
                if(a%i==0)
                {
                    v[x] = i;
                    x++;
                }
            }
            int prod = 1;
            for(int i=0; i<x; i++)
            {
                prod *= v[i];
            }
            Console.WriteLine($"Media aritmetica a divizorilor lui {a} este "+ ((v.Sum())/x));
            Console.WriteLine($"Media geometrica a divizorilor lui {a} este "+ Math.Pow(prod,1.0/x));
            Console.WriteLine($"Media armonica a divizorilor lui {a} este "+ (x-1)*prod/(double)v.Sum());
        }
    }
}

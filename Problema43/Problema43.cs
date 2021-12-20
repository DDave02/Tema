using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema43
{
    class Problema43
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati lungimea tabloului");
            int n=int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elementele tabloului pe linii separate: ");
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Tabloul initial este: ");
            for(int i=0;i<n;i++)
            {
                Console.Write($" {v[i]} ");
            }
            Console.WriteLine();
            tablouPatrat(v,n);
        }

        private static void tablouPatrat(int[] v,int n)
        {
            Console.Write("Valorile tabloului patrat sunt: ");
            for(int i=0;i<n;i++)
            {
                v[i] *= v[i];
                Console.Write($" {v[i]} ");
            }
            Console.WriteLine();
        }
    }
}

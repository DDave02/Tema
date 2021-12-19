using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declararea numerelor
            int n, k;
            //declarea elementelor intr-o combinare
            int d=1, y=1, x=1,z=1;
            //initializarea numerelor
            Console.WriteLine("Dati numerele n si k pe randuri sperate");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            //calcularea numaratorului
            for (int i = 1; i <= n; i++)
            {
                d *= i;
            }
            //calcularea elementelor numitorului
            for (int i = 1; i <= k; i++)
            {
                y *= i;
            }
            for (int i = 1; i <= n-k; i++)
            {
                x *= i;
            }
            //calcularea numitorului
            z = y * x;
            Console.WriteLine($"Combinari de {n} luate cate {k} este: "+(d/z));
        }
    }
}

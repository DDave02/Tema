using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema20
{
    class Problema20
    {
        static void Main(string[] args)
        {
            int a, x = 0, s = 0;
            Console.WriteLine("Dati un sir de numere pana la aparitia lui 0.");
            a = int.Parse(Console.ReadLine());
            x++;
            s += a;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a != 0)
                {
                    x++;
                    s += a;
                }
            }
            Console.WriteLine($"Media aritmetica este {s*1.0/x}");
        }
    }
}

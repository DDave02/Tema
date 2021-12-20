using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema14
{
    class Problema14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati numere intregi cate doriti. Ultima sa fie 0");
            int a,mx,mn;
            a = int.Parse(Console.ReadLine());
            mx = a;
            mn = a;
            while (true)
            {
                if (a == 0)
                    break;
                if (a < mn)
                    mn = a;
                if (mx < a)
                    mx = a;
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Numarul maxim este {mx} si nr minim este {mn}");
        }
    }
}

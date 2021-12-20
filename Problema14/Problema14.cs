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
            int a,mx,mn;
            a = int.Parse(Console.ReadLine());
            mx = a;
            mn = a;
            while (a!=0)
            {
                a = int.Parse(Console.ReadLine());
                if (a < mn)
                    mn = a;
                if (mx < a)
                    mx = a;
            }
            Console.WriteLine($"Numarul maxim este {mx} si nr minim este {mn}");
        }
    }
}

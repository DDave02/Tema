using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, m;
            Console.WriteLine("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());
            n = a; m = b;
            while (a != b)
                if (a > b)
                    a -= b;
                else
                    b -= a;
            Console.WriteLine("Cel mai mare divizor comun al {0} si {1} este {2}", n, m, a);
            Console.WriteLine("Cel mai mic multiplu comun al {0} si {1} este {2}", n,m,(n*m)/a);
        }
    }
}

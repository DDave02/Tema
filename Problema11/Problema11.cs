using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema11
{
    class Problema11
    {
        static void Main(string[] args)
        {   
            //declaram cele doua numere
            int a, b;
            //initializam cele 2 numere
            Console.WriteLine("Dati doua numere pe linii diferite: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //facem substitutii la cele doua numere
            int x = a, y = b;
            //utilizam formula lui euclid pt a afla cmmdc
            while(a!=b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            //daca cmmdc este 1 numerele sunt prime intre ele
            if (a == 1)
                Console.WriteLine($"Numerele {x} si {y} sunt prime inre ele");
            else
                Console.WriteLine($"Numerele {x} si {y} nu sunt prime intre ele");
        }
    }
}

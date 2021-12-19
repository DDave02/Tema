using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            //In problema nu ati precizat divizori proprii deci a aparatut o confuzie la inceput.
            //Declaraea celor 2 numere
            int x, y;
            //Initializarea celor 2 numere
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (numerePrietene(x,y))
            {
                Console.WriteLine($"Numerele {x} si {y} sunt prietene.");
            }
            else
                Console.WriteLine($"Numerele {x} si {y} nu sunt prietene.");
        }

        private static bool numerePrietene(int x, int y)
        {
            int sumaDivX = 0, sumaDivY = 0;
            for(int i=1;i<=x/2+1;i++)
            {
                if (x % i == 0)
                    sumaDivX += i;
            }
            for (int i = 1; i <=y/2+1 ; i++)
            {
                if (y % i == 0)
                    sumaDivY += i;
            }
            return (sumaDivX == y && sumaDivY == x);
        }
    }
}

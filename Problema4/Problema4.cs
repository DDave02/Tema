using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Problema4
    {
        static void Main(string[] args)
        {
            //declaram n si o suma egala cu 0
            int n, suma=0;
            //citim n
            Console.WriteLine("Dati un numar n: ");
            n = int.Parse(Console.ReadLine());
            //calculam suma
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                    suma += i;
            }
            //comparam n-ul cu suma
            if(suma==n)
            {
                Console.WriteLine("Numarul n este numar perfect.");
            }
            else
            {
                Console.WriteLine("Numarul n nu este perfect.");
            }
        }
    }
}

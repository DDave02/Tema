using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema44
{
    class Problema44
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati un nr natural n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("W");
            inmultire(n);
        }

        private static void inmultire(int n)
        {
            Console.WriteLine("Tabla inmultirii lui n este: ");
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine($"{n}*{i}={n*i}");
            }
        }
    }
}
